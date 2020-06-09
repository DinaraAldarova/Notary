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
            }
            //проверить, открываются ли нужные таблицы

            //создать таблички и переменные
            dataGridViewClient.Columns.Add("id", "Номер");
            dataGridViewClient.Columns.Add("Name", "Название");
            dataGridViewClient.Columns.Add("Activity", "Деятельность");
            dataGridViewClient.Columns.Add("Address", "Адрес");
            dataGridViewClient.Columns.Add("Phone", "Номер телефона");

            dataGridViewClient.Columns.Add("id", "Номер");
            dataGridViewClient.Columns.Add("Name", "Название");
            dataGridViewClient.Columns.Add("Activity", "Деятельность");
            dataGridViewClient.Columns.Add("Address", "Адрес");
            dataGridViewClient.Columns.Add("Phone", "Номер телефона");

            dataGridViewDiscont.Columns.Add("id", "Номер");
            dataGridViewDiscont.Columns.Add("Name", "Название");
            dataGridViewDiscont.Columns.Add("Activity", "Деятельность");
            dataGridViewDiscont.Columns.Add("Address", "Адрес");
            dataGridViewDiscont.Columns.Add("Phone", "Номер телефона");

            dataGridViewClient.Columns.Add("id", "Номер");
            dataGridViewClient.Columns.Add("Name", "Название");
            dataGridViewClient.Columns.Add("Activity", "Деятельность");
            dataGridViewClient.Columns.Add("Address", "Адрес");
            dataGridViewClient.Columns.Add("Phone", "Номер телефона");

            //обновить все данные
            RefreshClient();
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
                //запретить редактировать таблицу

            }
        }
    }
}
