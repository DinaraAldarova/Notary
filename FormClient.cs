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
    public partial class FormClient : Form
    {
        public Client client;
        
        public FormClient()
        {
            InitializeComponent();
            
            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            client = new Client();
            this.Text = "Создание клиента";
            buttonSave.Text = "Создать";
        }

        public FormClient(Client client)
        {
            InitializeComponent();

            textBoxName.Text = client.Name;
            textBoxActivity.Text = client.Activity;
            textBoxAddress.Text = client.Address;
            textBoxPhone.Text = client.Phone;

            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            this.client = client;
            this.Text = "Клиент №" + client.id;
            buttonSave.Text = "Изменить";
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (textBoxName.Text == "" || textBoxActivity.Text == "" || textBoxAddress.Text == "" || textBoxPhone.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    e.Cancel = true;
                }
                else
                {
                    client.Name = textBoxName.Text;
                    client.Activity = textBoxActivity.Text;
                    client.Address = textBoxAddress.Text;
                    client.Phone = textBoxPhone.Text;
                }
            }
        }
    }
}
