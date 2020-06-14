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
        //public Auth auth;
        public Auth.UserType userType = Auth.UserType.None;
        
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
            this.Visible = false;
            FormAuth formAuth = new FormAuth(this);
            formAuth.ShowDialog();

            switch (userType)
            {
                case Auth.UserType.None:
                    //Application.Exit();
                    break;
                case Auth.UserType.User:
                    buttonClientCreate.Visible = false;
                    buttonClientEdit.Visible = false;
                    buttonClientDelete.Visible = false;

                    buttonDealCreate.Visible = false;
                    buttonDealEdit.Visible = false;
                    buttonDealDelete.Visible = false;
                    buttonDealReport.Visible = false;

                    buttonServiceCreate.Visible = false;
                    buttonServiceEdit.Visible = false;
                    buttonServiceDelete.Visible = false;

                    buttonDiscontCreate.Visible = false;
                    buttonDiscontEdit.Visible = false;
                    buttonDiscontDelete.Visible = false;
                    break;
                case Auth.UserType.Admin:
                    buttonClientCreate.Visible = true;
                    buttonClientEdit.Visible = true;
                    buttonClientDelete.Visible = true;

                    buttonDealCreate.Visible = true;
                    buttonDealEdit.Visible = true;
                    buttonDealDelete.Visible = true;
                    buttonDealReport.Visible = true;

                    buttonServiceCreate.Visible = true;
                    buttonServiceEdit.Visible = true;
                    buttonServiceDelete.Visible = true;

                    buttonDiscontCreate.Visible = true;
                    buttonDiscontEdit.Visible = true;
                    buttonDiscontDelete.Visible = true;
                    break;
                default:
                    //Application.Exit();
                    break;
            }

            if(userType == Auth.UserType.Admin || userType == Auth.UserType.User)
            {
                saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

                //открыть БД
                dB = new DBNotary();
                if (!File.Exists(dB.databaseName))
                {
                    RecreateDB();
                    //обновление данных включено
                }
                else
                {
                    //обновить все данные
                    RefreshClient();
                    RefreshService();
                    RefreshDiscont();
                    RefreshDeal();
                }

                this.Visible = true;
            }
        }

        private void RefreshClient()
        {
            groupBoxClientId.Enabled = false;
            groupBoxClientId.Text = "Клиент";
            labelClient.Text = "";

            comboBoxClient.Items.Clear();
            clientsId = dB.getClientId();
            clients = new List<Client>();

            dataGridViewClient.Rows.Clear();
            dataGridViewClient.Columns.Clear();
            dataGridViewClient.Columns.Add("id", "Номер");
            dataGridViewClient.Columns.Add("Name", "Название");
            dataGridViewClient.Columns.Add("Activity", "Деятельность");
            dataGridViewClient.Columns.Add("Address", "Адрес");
            dataGridViewClient.Columns.Add("Phone", "Номер телефона");

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
            groupBoxDealId.Enabled = false;
            groupBoxDealId.Text = "Сделка";
            labelDeal.Text = "";

            comboBoxDeal.Items.Clear();
            dealsId = dB.getDealId();
            deals = new List<Deal>();

            dataGridViewDeal.Rows.Clear();
            dataGridViewDeal.Columns.Clear();
            dataGridViewDeal.Columns.Add("id", "Номер");
            dataGridViewDeal.Columns.Add("idClient", "Номер клиента");
            dataGridViewDeal.Columns.Add("Total", "Сумма");
            dataGridViewDeal.Columns.Add("DiscontPercent", "Процент скидки");
            dataGridViewDeal.Columns.Add("Commission", "Комиссионные");
            dataGridViewDeal.Columns.Add("Result", "Итог");
            dataGridViewDeal.Columns.Add("Description", "Описание");
            dataGridViewDeal.Columns.Add("idServices", "Номера услуг");
            dataGridViewDeal.Columns.Add("idDisconts", "Номера скидок");

            foreach (int id in dealsId)
            {
                comboBoxDeal.Items.Add(id);
                Deal deal = dB.getDeal(id);
                
                string idServices = "";
                foreach (int idService in deal.idServices)
                {
                    idServices += ", " + idService;

                    deal.Total += services.Find(x => x.id == idService).Price;
                }
                if (!string.IsNullOrEmpty(idServices))
                    idServices = idServices.Substring(2);
                
                string idDisconts = "";
                foreach (int idDiscont in deal.idDisconts)
                {
                    idDisconts += ", " + idDiscont;

                    deal.DiscontPercent += disconts.Find(x => x.id == idDiscont).Percent;
                }
                if (!string.IsNullOrEmpty(idDisconts))
                    idDisconts = idDisconts.Substring(2);

                deal.Commission = deal.Total / 100 * (100 - deal.DiscontPercent) / 100 * Deal.ComissionPercent;

                dataGridViewDeal.Rows.Add(deal.id, deal.idClient, deal.Total, deal.DiscontPercent, deal.Commission, deal.Total / 100 * (100 - deal.DiscontPercent) + deal.Commission, deal.Description, idServices, idDisconts);

                deals.Add(deal);
            }
        }

        private void RefreshService()
        {
            groupBoxServiceId.Enabled = false;
            groupBoxServiceId.Text = "Услуга";
            labelService.Text = "";
            
            comboBoxService.Items.Clear();
            servicesId = dB.getServiceId();
            services= new List<Service>();

            dataGridViewService.Rows.Clear();
            dataGridViewService.Columns.Clear();
            dataGridViewService.Columns.Add("id", "Номер");
            dataGridViewService.Columns.Add("Name", "Название");
            dataGridViewService.Columns.Add("Description", "Описание");
            dataGridViewService.Columns.Add("Price", "Стоимость");

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
            groupBoxDiscontId.Enabled = false;
            groupBoxDiscontId.Text = "Скидка";
            labelDiscont.Text = "";

            comboBoxDiscont.Items.Clear();
            discontsId = dB.getDiscontId();
            disconts = new List<Discont>();

            dataGridViewDiscont.Rows.Clear();
            dataGridViewDiscont.Columns.Clear();
            dataGridViewDiscont.Columns.Add("id", "Номер");
            dataGridViewDiscont.Columns.Add("Name", "Название");
            dataGridViewDiscont.Columns.Add("Description", "Описание");
            dataGridViewDiscont.Columns.Add("Percent", "Скидка в процентах");

            foreach (int id in discontsId)
            {
                comboBoxDiscont.Items.Add(id);
                Discont discont = dB.getDiscont(id);
                disconts.Add(discont);
                dataGridViewDiscont.Rows.Add(discont.id, discont.Name, discont.Description, discont.Percent);
            }
        }

        private void RecreateDB()
        {
            dB.RecreateDB();

            clients = new List<Client>();
            clients.Add(new Client("АРХИЛД",    "Туризм",           "433421, г. Южа, ул. Руставели, дом 49, офис 315",                  "+7 (906) 638-62-18"));
            clients.Add(new Client("РЕИНГ",     "Авиакомпания",     "692558, г. Аскарово, ул. Миргородский 2-й пер, дом 94, офис 125",  "+7 (961) 615-63-49"));
            clients.Add(new Client("НИРГРИС",   "Автотранспорт",    "171361, г. Новоаннинский, ул. Олега Кошевого, дом 99, офис 61",    "+7 (972) 867-47-89"));
            clients.Add(new Client("РЕКСОЛЬ",   "Инструмент",       "692684, г. Ивня, ул. Морской пр-кт, дом 39, офис 197",             "+7 (951) 906-67-62"));
            clients.Add(new Client("ОНЭШ",      "Спорт",            "618422, г. Аргун, ул. Интернациональная, дом 99, офис 232",        "+7 (979) 918-60-99"));
            clients.Add(new Client("РЕКТТА",    "Недвижимость",     "606488, г. Сортавала, ул. Волгоградский пр-кт, дом 7, офис 213",   "+7 (933) 738-10-15"));
            clients.Add(new Client("БУРА",      "Сантехника",       "174755, г. Ярково, ул. Дуговая, дом 69, офис 281",                 "+7 (946) 383-77-85"));
            clients.Add(new Client("ИГООУ",     "Образование",      "391728, г. Дубровка, ул. Комбинатский пер, дом 40, офис 191",      "+7 (979) 469-39-49"));
            clients.Add(new Client("РАДОР",     "Безопасность",     "347736, г. Шадринск, ул. Энтузиастов 2-я, дом 18, офис 163",       "+7 (927) 372-64-93"));
            clients.Add(new Client("ГАРСО",     "Топливо",          "352118, г. Томск, ул. Витимская, дом 37, офис 429",                "+7 (994) 764-43-77"));
            foreach (Client client in clients)
            {
                dB.setClient(client);
            }
            RefreshClient();

            services = new List<Service>();
            services.Add(new Service("Нотариальная доверенность", "Удостоверение доверенности от имени физических лиц ", 2100));
            services.Add(new Service("Завещание на наследство", "Удостоверение завещания", 2800));
            services.Add(new Service("Наследство у нотариуса", "Выдача свидетельства о праве на наследство по закону и по завещанию на недвижимое имущество (с каждого наследника за каждый объект, указанный в свидетельстве)", 7800));
            services.Add(new Service("Нотариальный договор", "Удостоверение сделок, предметом которых является отчуждение недвижимого имущества, подлежащих обязательному нотариальному удостоверению", 6500));
            services.Add(new Service("Договор купли-продажи", "Удостоверение сделок, предметом которых является отчуждение недвижимого имущества, не подлежащих обязательному нотариальному удостоверению", 13100));
            services.Add(new Service("Договор дарения", "Удостоверение сделок, предметом которых является отчуждение недвижимого имущества, подлежащих обязательному нотариальному удостоверению", 6500));
            services.Add(new Service("Брачный договор", "Удостоверение брачного договора", 17000));
            services.Add(new Service("Нотариальное согласие", "Удостоверение иного договора (соглашения)", 13100));
            services.Add(new Service("Согласие на продажу", "Удостоверение согласия супруга на заключение сделки по распоряжению имуществом, права на которое подлежат государственной регистрации, сделки, для которой законом установлена обязательная нотариальная форма, или сделки, подлежащей обязательной государственной регистрации", 2100));
            services.Add(new Service("Материнский капитал", "Удостоверение договора по оформлению в долевую собственность родителей и детей жилого помещения, приобретенного с использованием средств материнского капитала", 6500));
            foreach (Service service in services)
            {
                dB.setService(service);
            }
            RefreshService();

            disconts = new List<Discont>();
            disconts.Add(new Discont("Отчуждение недвижимого имущества", "Полагается супругу, родителям, детям, внукам согласно п.п. 1 п.1 ст. 22.1 Основ о нотариате", 20));
            disconts.Add(new Discont("Договор дарения", "Полагается детям, в том числе усыновленным, супругу, родителям, полнородным братьям и сестрам согласно п.п. 2 п.1 ст. 22.1 Основ о нотариате", 30));
            disconts.Add(new Discont("Доверенности на право пользования имуществом, кроме автотранспортных средств", "Полагается детям, в том числе усыновленным, супругу, родителям, полнородным братьям и сестрам согласно п.п. 15 п.1 ст.333.24 Налогового кодекса Российской Федерации", 25));
            disconts.Add(new Discont("Доверенности на право пользования автотранспортными средствами", "Полагается детям, в том числе усыновленным, супругу, родителям, полнородным братьям и сестрам согласно п.п. 15 п.1 ст.333.24 Налогового кодекса Российской Федерации", 5));
            disconts.Add(new Discont("Свидетельство о праве на наследство", "Полагается детям, в том числе усыновленным, супругу, родителям, полнородным братьям и сестрам наследодателя согласно п.п. 22 п.1 ст.333.24 Налогового кодекса Российской Федерации", 10));
            foreach (Discont discont in disconts)
            {
                dB.setDiscont(discont);
            }
            RefreshDiscont();

            Random random = new Random();
            deals = new List<Deal>();
            for (int i = 0; i < 10; i++)
            {
                Deal deal = new Deal(random.Next(1, clients.Count + 1), "Сделка №" + (i+1));
                
                int countServices = random.Next(1, 11);
                for(int j = 0; j < countServices; j++)
                {
                    deal.AddService(random.Next(1, services.Count + 1));
                }

                foreach (Discont discont in disconts)
                {
                    if (random.NextDouble() > 0.8)
                    {
                        deal.AddDiscont(discont.id);
                    }
                }
                deals.Add(deal);
                dB.setDeal(deal);
            }
            RefreshDeal();
        }

        private string DealReport(int idDeal)
        {
            int index = deals.FindIndex(x => x.id == idDeal);
            string text = "Название организации: " + clients.Find(x => x.id == deals[index].idClient).Name + "\n" +
                          "Описание сделки: " + deals[index].Description + "\n\n";

            text += "Список услуг\n";
            foreach (Service service in services.FindAll(x => deals[index].idServices.Contains(x.id)))
            {
                text += String.Format("{0, -80} - {1, 10:f2}₽\n", service.Name, service.Price);
            }
            text += String.Format("{0, 80}   {1, 10:f2}₽\n\n", "Итого", deals[index].Total);

            text += "Список скидок\n";
            foreach (Discont discont in disconts.FindAll(x => deals[index].idDisconts.Contains(x.id)))
            {
                text += String.Format("{0, -80} - {1, 10:f2}%\n", discont.Name, discont.Percent);
            }
            text += String.Format("{0, 80}   {1, 10:f2}%\n\n", "Скидка", deals[index].DiscontPercent);

            text += String.Format("{0, 80}   {1, 10:f2}₽\n", "Комиссия", deals[index].Commission);
            text += String.Format("{0, 80}   {1, 10:f2}₽", "К оплате", (deals[index].Total / 100 * deals[index].DiscontPercent + deals[index].Commission));
            return text;
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxClientId.Enabled = false;
            if (clients.Count > 0)
            {
                int idClient = Convert.ToInt32(comboBoxClient.SelectedItem);
                int index = clients.FindIndex(x => x.id == idClient);
                string text = "Название организации: " + clients[index].Name + "\n\n" +
                              "Вид деятельности: " + clients[index].Activity + "\n\n" +
                              "Адрес: " + clients[index].Address + "\n\n" +
                              "Телефон: " + clients[index].Phone;
                labelClient.Text = text;
                groupBoxClientId.Text = "Клиент №" + idClient;
                groupBoxClientId.Enabled = true;
            }
        }

        private void comboBoxDeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxDealId.Enabled = false;
            if (deals.Count > 0)
            {
                int idDeal = Convert.ToInt32(comboBoxDeal.SelectedItem);
                labelDeal.Text = DealReport(idDeal);
                groupBoxDealId.Text = "Сделка №" + idDeal;
                groupBoxDealId.Enabled = true;
            }
        }

        private void comboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxServiceId.Enabled = false;
            if (services.Count > 0)
            {
                int idService = Convert.ToInt32(comboBoxService.SelectedItem);
                int index = services.FindIndex(x => x.id == idService);
                string text = "Название услуги: " + services[index].Name + "\n\n" +
                              "Описание услуги: " + services[index].Description + "\n\n" +
                              "Стоимость услуги: " + services[index].Price + "₽";
                labelService.Text = text;
                groupBoxServiceId.Text = "Услуга №" + idService;
                groupBoxServiceId.Enabled = true;
            }
        }

        private void comboBoxDiscont_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxDiscontId.Enabled = false;
            if (disconts.Count > 0)
            {
                int idDiscont = Convert.ToInt32(comboBoxDiscont.SelectedItem);
                int index = disconts.FindIndex(x => x.id == idDiscont);
                string text = "Название скидки: " + disconts[index].Name + "\n\n" +
                              "Описание скидки: " + disconts[index].Description + "\n\n" +
                              "Размер скидки: " + disconts[index].Percent + "%";
                labelDiscont.Text = text;
                groupBoxDiscontId.Text = "Скидка №" + idDiscont;
                groupBoxDiscontId.Enabled = true;
            }
        }

        private string endingOfTheWord(string word, int number)
        {
            if (((number % 100) > 10) && ((number % 100) < 20))
                switch (word)
                {
                    case "Будет удалено": return "Будет удалено";
                    case "сделок": return "сделок";
                    default: return "";
                }
            if (number % 10 == 1)
                switch (word)
                {
                    case "Будет удалено": return "Будет удалена";
                    case "сделок": return "сделка";
                    default: return "";
                }
            if ((number % 10 == 2) || (number % 10 == 3) || (number % 10 == 4))
                switch (word)
                {
                    case "Будет удалено": return "Будут удалены";
                    case "сделок": return "сделки";
                    default: return "";
                }
            switch (word)
            {
                case "Будет удалено": return "Будет удалено";
                case "сделок": return "сделок";
                default: return "";
            }
        }

        private void buttonClientDelete_Click(object sender, EventArgs e)
        {
            groupBoxClientId.Enabled = false;
            int idClient = Convert.ToInt32(comboBoxClient.SelectedItem);
            int index = clients.FindIndex(x => x.id == idClient);

            List<Deal> dealDeleting = deals.FindAll(x => x.idClient == idClient);
            
            if(dealDeleting.Count > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("{0} {1} {2}", endingOfTheWord("Будет удалено", dealDeleting.Count), dealDeleting.Count, endingOfTheWord("сделок", dealDeleting.Count)),
                            "Внимание!",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    foreach (Deal deal in dealDeleting)
                    {
                        dB.deleteDeal(deal);
                    }
                    dB.deleteClient(clients[index]);

                    RefreshClient();
                    RefreshDeal();
                }
                else
                {
                    groupBoxClientId.Enabled = true;
                }
            }
            else
            {
                dB.deleteClient(clients[index]);
                RefreshClient();
            }
        }

        private void buttonDealDelete_Click(object sender, EventArgs e)
        {
            groupBoxDealId.Enabled = false;
            int idDeal = Convert.ToInt32(comboBoxDeal.SelectedItem);
            int index = deals.FindIndex(x => x.id == idDeal);

            dB.deleteDeal(deals[index]);
            RefreshDeal();
        }

        private void buttonServiceDelete_Click(object sender, EventArgs e)
        {
            groupBoxServiceId.Enabled = false;
            int idService = Convert.ToInt32(comboBoxService.SelectedItem);
            int index = services.FindIndex(x => x.id == idService);

            List<Deal> dealDeleting = deals.FindAll(x => x.idServices.Contains(idService));

            if (dealDeleting.Count > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("{0} {1} {2}", endingOfTheWord("Будет удалено", dealDeleting.Count), dealDeleting.Count, endingOfTheWord("сделок", dealDeleting.Count)),
                            "Внимание!",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    foreach (Deal deal in dealDeleting)
                    {
                        dB.deleteDeal(deal);
                    }
                    dB.deleteService(services[index]);

                    RefreshService();
                    RefreshDeal();
                }
                else
                {
                    groupBoxServiceId.Enabled = true;
                }
            }
            else
            {
                dB.deleteService(services[index]);
                RefreshService();
            }
        }

        private void buttonDiscontDelete_Click(object sender, EventArgs e)
        {
            groupBoxDiscontId.Enabled = false;
            int idDiscont = Convert.ToInt32(comboBoxDiscont.SelectedItem);
            int index = disconts.FindIndex(x => x.id == idDiscont);

            List<Deal> dealDeleting = deals.FindAll(x => x.idDisconts.Contains(idDiscont));

            if (dealDeleting.Count > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("{0} {1} {2}", endingOfTheWord("Будет удалено", dealDeleting.Count), dealDeleting.Count, endingOfTheWord("сделок", dealDeleting.Count)),
                            "Внимание!",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    foreach (Deal deal in dealDeleting)
                    {
                        dB.deleteDeal(deal);
                    }
                    dB.deleteDiscont(disconts[index]);

                    RefreshDiscont();
                    RefreshDeal();
                }
                else
                {
                    groupBoxDiscontId.Enabled = true;
                }
            }
            else
            {
                dB.deleteDiscont(disconts[index]);
                RefreshDiscont();
            }
        }

        private void buttonDealReport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllText(filename, DealReport(Convert.ToInt32(comboBoxDeal.SelectedItem)));
            //MessageBox.Show("Файл сохранен");
        }

        private void buttonClientCreate_Click(object sender, EventArgs e)
        {
            FormClient form = new FormClient();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setClient(form.client);
                RefreshClient();
            }
        }

        private void buttonClientEdit_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(comboBoxClient.SelectedItem);
            int index = clients.FindIndex(x => x.id == idClient);

            FormClient form = new FormClient(clients[index]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setClient(form.client);
                RefreshClient();
            }
        }

        private void buttonDealCreate_Click(object sender, EventArgs e)
        {
            FormDeal form = new FormDeal(clients, services, disconts);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setDeal(form.deal);
                RefreshDeal();
            }
        }

        private void buttonDealEdit_Click(object sender, EventArgs e)
        {
            int idDeal = Convert.ToInt32(comboBoxDeal.SelectedItem);
            int index = deals.FindIndex(x => x.id == idDeal);

            FormDeal form = new FormDeal(deals[index], clients, services, disconts);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setDeal(form.deal);
                RefreshDeal();
            }
        }

        private void buttonServiceCreate_Click(object sender, EventArgs e)
        {
            FormService form = new FormService();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setService(form.service);
                RefreshService();
            }
        }

        private void buttonServiceEdit_Click(object sender, EventArgs e)
        {
            int idService = Convert.ToInt32(comboBoxService.SelectedItem);
            int index = services.FindIndex(x => x.id == idService);

            FormService form = new FormService(services[index]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setService(form.service);
                RefreshService();
            }
        }

        private void buttonDiscontCreate_Click(object sender, EventArgs e)
        {
            FormDiscont form = new FormDiscont();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setDiscont(form.discont);
                RefreshDiscont();
            }
        }

        private void buttonDiscontEdit_Click(object sender, EventArgs e)
        {
            int idDiscont = Convert.ToInt32(comboBoxDiscont.SelectedItem);
            int index = disconts.FindIndex(x => x.id == idDiscont);

            FormDiscont form = new FormDiscont(disconts[index]);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dB.setDiscont(form.discont);
                RefreshDiscont();
            }
        }

        private void dataGridViewClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClient.SelectedRows.Count > 0)
                comboBoxClient.SelectedItem = dataGridViewClient.SelectedRows[0].Cells["id"].Value;
        }

        private void dataGridViewDeal_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDeal.SelectedRows.Count > 0)
                comboBoxDeal.SelectedItem = dataGridViewDeal.SelectedRows[0].Cells["id"].Value;
        }

        private void dataGridViewService_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewService.SelectedRows.Count > 0)
                comboBoxService.SelectedItem = dataGridViewService.SelectedRows[0].Cells["id"].Value;
        }

        private void dataGridViewDiscont_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDiscont.SelectedRows.Count > 0)
                comboBoxDiscont.SelectedItem = dataGridViewDiscont.SelectedRows[0].Cells["id"].Value;
        }
    }
}
