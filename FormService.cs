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
    public partial class FormService : Form
    {
        public Service service;
        
        public FormService()
        {
            InitializeComponent();
            
            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            service = new Service();
            this.Text = "Создание услугу";
            buttonSave.Text = "Создать";
        }

        public FormService(Service service)
        {
            InitializeComponent();

            textBoxName.Text = service.Name;
            textBoxDescription.Text = service.Description;
            numericUpDownPrice.Value = Convert.ToDecimal(service.Price);

            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            this.service = service;
            this.Text = "Услуга №" + service.id;
            buttonSave.Text = "Изменить";
        }

        private void FormService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (textBoxName.Text == "" || textBoxDescription.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    e.Cancel = true;
                }
                else
                {
                    service.Name = textBoxName.Text;
                    service.Description = textBoxDescription.Text;
                    service.Price = Convert.ToDouble(numericUpDownPrice.Value);
                }
            }
        }
    }
}
