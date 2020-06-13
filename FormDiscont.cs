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
    public partial class FormDiscont : Form
    {
        public Discont discont;
        
        public FormDiscont()
        {
            InitializeComponent();
            
            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            discont = new Discont();
            this.Text = "Создание скидку";
            buttonSave.Text = "Создать";
        }

        public FormDiscont(Discont discont)
        {
            InitializeComponent();

            textBoxName.Text = discont.Name;
            textBoxDescription.Text = discont.Description;
            numericUpDownPercent.Value = Convert.ToDecimal(discont.Percent);

            buttonSave.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            this.discont = discont;
            this.Text = "Скидка №" + discont.id;
            buttonSave.Text = "Изменить";
        }

        private void FormDiscont_FormClosing(object sender, FormClosingEventArgs e)
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
                    discont.Name = textBoxName.Text;
                    discont.Description = textBoxDescription.Text;
                    discont.Percent = Convert.ToDouble(numericUpDownPercent.Value);
                }
            }
        }
    }
}
