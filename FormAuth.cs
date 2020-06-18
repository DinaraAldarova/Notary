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
        private FormMain main;
        private Auth auth;
        private int numberOfAttempts = 1;
        private const int maxNumberOfAttempts = 3;

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
                if (numberOfAttempts < maxNumberOfAttempts)
                {
                    MessageBox.Show("Неверный логин или пароль\nПожалуйста, повторите ввод");
                    numberOfAttempts++;
                    textBoxPassword.Text = "";
                    textBoxPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль\nПревышено количество попыток ввода пароля. Приложение будет закрыто");
                    Application.Exit();
                }
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
