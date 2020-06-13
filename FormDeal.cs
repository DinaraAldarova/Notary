using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Нотариус.Models;

namespace Нотариус
{
    public partial class FormDeal : Form
    {
        public Deal deal;

        List<Client> clients;

        List<Service> services;

        List<Discont> disconts;

        public FormDeal(List<Client> clients, List<Service> services, List<Discont> disconts)
        {
            InitializeComponent();

            foreach (Client client in clients)
            {
                comboBoxClientId.Items.Add(client.id + " " + client.Name);
            }
            foreach (Service service in services)
            {
                checkedListBoxService.Items.Add(service.id + " " + service.Name);
            }
            foreach (Discont discont in disconts)
            {
                checkedListBoxDiscont.Items.Add(discont.id + " " + discont.Name);
            }

            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            deal = new Deal();
            this.clients = clients;
            this.services = services;
            this.disconts = disconts;
            this.Text = "Создание сделки";
            buttonSave.Text = "Создать";
            labelReport.Text = Report();
        }

        public FormDeal(Deal deal, List<Client> clients, List<Service> services, List<Discont> disconts)
        {
            InitializeComponent();

            foreach (Client client in clients)
            {
                comboBoxClientId.Items.Add(client.id + " " + client.Name);
            }
            comboBoxClientId.SelectedIndex = comboBoxClientId.Items.IndexOf(deal.idClient + " " + clients.Find(x => x.id == deal.idClient).Name);

            textBoxDescription.Text = deal.Description;

            foreach (Service service in services)
            {
                string text = service.id + " " + service.Name;
                checkedListBoxService.Items.Add(text);
                if (deal.idServices.Contains(service.id))
                    checkedListBoxService.SetItemChecked(checkedListBoxService.Items.IndexOf(text), true);
            }
            foreach (Discont discont in disconts)
            {
                string text = discont.id + " " + discont.Name;
                checkedListBoxDiscont.Items.Add(text);
                if (deal.idDisconts.Contains(discont.id))
                    checkedListBoxDiscont.SetItemChecked(checkedListBoxDiscont.Items.IndexOf(text), true);
            }
            
            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            this.deal = deal;
            this.clients = clients;
            this.services = services;
            this.disconts = disconts;
            this.Text = "Сделка №" + deal.id;
            buttonSave.Text = "Изменить";
            labelReport.Text = Report();
        }

        private void FormDeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (comboBoxClientId.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите клиента");
                    e.Cancel = true;
                }
                else if (textBoxDescription.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните описание сделки");
                    e.Cancel = true;
                }
                else if (checkedListBoxService.CheckedItems == null)
                {
                    MessageBox.Show("Пожалуйста, отметьте услуги");
                    e.Cancel = true;
                }
                else
                {
                    deal.idClient = Convert.ToInt32(comboBoxClientId.SelectedItem.ToString().Split(' ')[0]);
                    deal.Description = textBoxDescription.Text;
                    
                    deal.idServices.Clear();
                    foreach (var item in checkedListBoxService.CheckedItems)
                    {
                        deal.idServices.Add(Convert.ToInt32(item.ToString().Split(' ')[0]));
                    }

                    deal.idDisconts.Clear();
                    foreach (var item in checkedListBoxDiscont.CheckedItems)
                    {
                        deal.idDisconts.Add(Convert.ToInt32(item.ToString().Split(' ')[0]));
                    }
                }
            }
        }

        private string Report()
        {
            string text = "Список услуг\n";
            deal.Total = 0;
            foreach (Service service in services.FindAll(x => checkedListBoxService.CheckedItems.Contains(x.id + " " + x.Name)))
            {
                deal.Total += service.Price;
                text += String.Format("{0, -80} - {1, 10:f2}₽\n", service.Name, service.Price);
            }
            text += String.Format("{0, 80}   {1, 10:f2}₽\n\n", "Итого", deal.Total);

            text += "Список скидок\n";
            deal.DiscontPercent = 0;
            foreach (Discont discont in disconts.FindAll(x => checkedListBoxDiscont.CheckedItems.Contains(x.id + " " + x.Name)))
            {
                deal.DiscontPercent += discont.Percent;
                text += String.Format("{0, -80} - {1, 10:f2}%\n", discont.Name, discont.Percent);
            }
            text += String.Format("{0, 80}   {1, 10:f2}%\n\n", "Скидка", deal.DiscontPercent);

            deal.Commission = deal.Total / 100 * (100 - deal.DiscontPercent) / 100 * Deal.ComissionPercent;
            text += String.Format("{0, 80}   {1, 10:f2}₽\n", "Комиссия", deal.Commission);
            text += String.Format("{0, 80}   {1, 10:f2}₽", "К оплате", (deal.Total / 100 * deal.DiscontPercent + deal.Commission));
            return text;
        }

        private void checkedListBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReport.Text = Report();
        }

        private void checkedListBoxDiscont_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelReport.Text = Report();
        }
    }
}
