using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt_kfu_2
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void button_entrance_Click(object sender, EventArgs e)
        {

        }


        private void Regestration_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "Email";
            textBoxEmail.ForeColor = Color.Gray;
            textBoxLogin.Text = "Логин";
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPasswod.Text = "Пароль";
            textBoxPasswod.ForeColor = Color.Gray;
            textBoxSecondPassword.Text = "Повторите пароль";
            textBoxSecondPassword.ForeColor = Color.Gray;
            textBoxName.Text = "Имя";
            textBoxName.ForeColor = Color.Gray;
            textBoxSurename.Text = "Фамилия";
            textBoxSurename.ForeColor = Color.Gray;
            textBoxFathername.Text = "Отчество(если есть)";
            textBoxFathername.ForeColor = Color.Gray;
            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals("Email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }
        
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals("Логин"))
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }   
        }

        private void textBoxPasswod_Enter(object sender, EventArgs e)
        {
            if(textBoxPasswod.Text.Equals("Пароль"))
            {
                textBoxPasswod.Text = "";
                textBoxPasswod.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswod_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxPasswod.Text))
            {
                textBoxPasswod.Text = "Пароль";
                textBoxPasswod.ForeColor = Color.Gray;
            }
        }

        private void textBoxSecondPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSecondPassword.Text))
            {
                textBoxSecondPassword.Text = "Повторите пароль";
                textBoxSecondPassword.ForeColor= Color.Gray;
            }
        }

        private void textBoxSecondPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondPassword.Text.Equals("Повторите пароль"))
            {
                textBoxSecondPassword.Text = "";
                textBoxSecondPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.Text = "Имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals("Имя"))
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxSurename_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSurename.Text))
            {
                textBoxSurename.Text = "Фамилия";
                textBoxSurename.ForeColor = Color.Gray;
            }
        }

        private void textBoxSurename_Enter(object sender, EventArgs e)
        {
            if (textBoxSurename.Text.Equals("Фамилия"))
            {
                textBoxSurename.Text = "";
                textBoxSurename.ForeColor = Color.Black;
            }
        }

        private void textBoxFathername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFathername.Text))
            {
                textBoxFathername.Text = "Отчество(если есть)";
                textBoxFathername.ForeColor = Color.Gray;
            }
        }

        private void textBoxFathername_Enter(object sender, EventArgs e)
        {
            if (textBoxFathername.Text.Equals("Отчество(если есть)"))
            {
                textBoxFathername.Text = "";
                textBoxFathername.ForeColor = Color.Black;
            }
        }
    }
}
