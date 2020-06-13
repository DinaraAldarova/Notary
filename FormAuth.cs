using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Нотариус
{
    public partial class FormAuth : Form
    {
        FormMain main;
        Auth auth;

        public FormAuth(FormMain main)
        {
            this.main = main;
            InitializeComponent();
            this.textBoxPassword.PasswordChar = '*';
            auth = new Auth();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            auth = new Auth(textBoxLogin.Text, textBoxPassword.Text);
            if (auth.userType == Auth.UserType.None)
            {
                MessageBox.Show("Неверный логин или пароль");
                textBoxPassword.Text = "";
                textBoxPassword.Focus();
            }
            else
            {
                main.userType = auth.userType;
                this.Close();
            }
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (auth.userType == Auth.UserType.None)
            {
                Application.Exit();
            }
        }
    }
}
