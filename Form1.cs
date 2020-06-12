using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Нотариус.Models;

namespace Нотариус
{
    public partial class FormMain : Form
    {
        DBNotary dB;
        
        List<int> clientsId;
        List<Client> clients;

        List<int> dealsId;
        List<Deal> deals;

        List<int> servicesId;
        List<Service> services;

        List<int> discontsId;
        List<Discont> disconts;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //открыть БД
            dB = new DBNotary();
            if (!File.Exists(dB.databaseName))
            {
                dB.RecreateDB();
                //dB.setClient(new Client("ПГНИУ"));
                //dB.setService(new Service("Договор"));
                //dB.setDiscont(new Discont("Новогодняя"));
                //dB.setDeal(new Deal(1));
            }

            dB.setDiscont(new Discont("Новогодняя", "Специально к новому году", 10, 0));
            dB.setService(new Service("Договор купли-продажи", "Составим за вас договор", 3000));
            Deal deal = new Deal(1, 8000, 300, "Сделали все за вас");
            deal.idServices.Add(1);
            deal.idDisconts.Add(1);
            dB.setDeal(deal);
            //проверить, открываются ли нужные таблицы

            //создать таблички и переменные
            dataGridViewClient.Columns.Add("id", "Номер");
            dataGridViewClient.Columns.Add("Name", "Название");
            dataGridViewClient.Columns.Add("Activity", "Деятельность");
            dataGridViewClient.Columns.Add("Address", "Адрес");
            dataGridViewClient.Columns.Add("Phone", "Номер телефона");

            dataGridViewDeal.Columns.Add("id", "Номер");
            dataGridViewDeal.Columns.Add("idClient", "Номер клиента");
            dataGridViewDeal.Columns.Add("Total", "Сумма");
            dataGridViewDeal.Columns.Add("Commission", "Комиссионные");
            dataGridViewDeal.Columns.Add("Description", "Описание");
            dataGridViewDeal.Columns.Add("idServices", "Номера услуг");
            dataGridViewDeal.Columns.Add("idDisconts", "Номера скидок");

            dataGridViewService.Columns.Add("id", "Номер");
            dataGridViewService.Columns.Add("Name", "Название");
            dataGridViewService.Columns.Add("Description", "Описание");
            dataGridViewService.Columns.Add("Price", "Стоимость");

            dataGridViewDiscont.Columns.Add("id", "Номер");
            dataGridViewDiscont.Columns.Add("Name", "Название");
            dataGridViewDiscont.Columns.Add("Description", "Описание");
            dataGridViewDiscont.Columns.Add("Percent", "Скидка в процентах");
            dataGridViewDiscont.Columns.Add("Value", "Сумма скидки");

            //обновить все данные
            RefreshClient();
            RefreshDeal();
            RefreshService();
            RefreshDiscont();
        }

        private void RefreshClient()
        {
            comboBoxClient.Items.Clear();
            clientsId = dB.getClientId();

            clients = new List<Client>();
            dataGridViewClient.Rows.Clear();

            foreach (int id in clientsId)
            {
                comboBoxClient.Items.Add(id);
                Client client = dB.getClient(id);
                clients.Add(client);
                dataGridViewClient.Rows.Add(client.id, client.Name, client.Activity, client.Address, client.Phone);
            }
        }

        private void RefreshDeal()
        {
            comboBoxDeal.Items.Clear();
            dealsId = dB.getDealId();

            deals = new List<Deal>();
            dataGridViewDeal.Rows.Clear();

            foreach (int id in dealsId)
            {
                comboBoxDeal.Items.Add(id);
                Deal deal = dB.getDeal(id);
                deals.Add(deal);
                
                string idServices = "";
                foreach (int idService in deal.idServices)
                {
                    idServices += idService + ", ";
                }
                if (!string.IsNullOrEmpty(idServices))
                    idServices = idServices.Substring(2);
                
                string idDisconts = "";
                foreach (int idDiscont in deal.idDisconts)
                {
                    idDisconts += idDiscont + ", ";
                }
                if (!string.IsNullOrEmpty(idDisconts))
                    idDisconts = idDisconts.Substring(2);

                dataGridViewDeal.Rows.Add(deal.Id, deal.IdClient, deal.Total, deal.Commission, deal.Description, idServices, idDisconts);
            }
        }

        private void RefreshService()
        {
            comboBoxService.Items.Clear();
            servicesId = dB.getServiceId();

            services= new List<Service>();
            dataGridViewService.Rows.Clear();

            foreach (int id in servicesId)
            {
                comboBoxService.Items.Add(id);
                Service service = dB.getService(id);
                services.Add(service);
                dataGridViewService.Rows.Add(service.id, service.Name, service.Description, service.Price);
            }
        }

        private void RefreshDiscont()
        {
            comboBoxDiscont.Items.Clear();
            discontsId = dB.getDiscontId();

            disconts = new List<Discont>();
            dataGridViewDiscont.Rows.Clear();

            foreach (int id in discontsId)
            {
                comboBoxDiscont.Items.Add(id);
                Discont discont = dB.getDiscont(id);
                disconts.Add(discont);
                dataGridViewDiscont.Rows.Add(discont.id, discont.Name, discont.Description, discont.Percent, discont.Value);
            }
        }
    }
}
