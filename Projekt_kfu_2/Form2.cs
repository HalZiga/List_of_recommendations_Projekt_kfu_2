using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projekt_kfu_2
{
    public partial class Regestration : Form
    {
        private bool exReg;
        public Regestration()
        {
            InitializeComponent();
        }

        private void Regestration_Load(object sender, EventArgs e)
        {
            textBoxEmail.Text = "Email";
            textBoxEmail.ForeColor = Color.Gray;
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


        private void buttonRegestration_Click(object sender, EventArgs e)
        {
            Class_for_db.Connect();
            Class_for_db.openconnection();


            if (textBoxName.Text.Equals("Имя") || textBoxEmail.Text.Equals("Email") || textBoxPasswod.Text.Equals("Пароль") || textBoxSurename.Text.Equals("Фамилия") )
            {
                MessageBox.Show("Введите все данные");
            }

            if (Class_for_db.UserExist(textBoxName.Text, textBoxSurename.Text, textBoxFathername.Text)) { return; }
            if (textBoxName.Text != "Имя" && textBoxEmail.Text != "Email" && textBoxPasswod.Text != "Пароль" && textBoxSurename.Text != "Фамилия" )
            {

                var pass = textBoxPasswod.Text;
                var Name = textBoxName.Text;
                var email = textBoxEmail.Text;
                var lastName = textBoxFathername.Text;
                var Surname = textBoxSurename.Text;
                if (textBoxFathername.Text.Equals("Отчество(если имеется)"))
                {
                    lastName = "";
                }
                //var un = new SqlCommand("select max(user_id) from users;", db.getConnection());
                //var userid = (Int32)un.ExecuteScalar() + 1;
                try
                {
                    ClassMailPassword messageCode = new ClassMailPassword(email);
                    messageCode.MailMessag();

                    InputDialog inputDialog = new InputDialog();
                    inputDialog.ShowDialog();

                    if (inputDialog.Flag == true)
                    {
                        
                        if (Class_for_db.AddUser(Name, Surname, lastName, email, pass) == 1)
                        {
                            MessageBox.Show("Регистрация успешно завершена");
                            exReg = true;
                        }
                        else { MessageBox.Show("Что-то пошло не так.."); }

                    }
                    else
                    {
                        if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxPasswod.Text == "")
                        {
                            MessageBox.Show("Проверьте введенные данные еще раз");
                        }
                        if (Class_for_db.UserExist(textBoxName.Text, textBoxSurename.Text, textBoxFathername.Text)) { return; }
                    }
                }
                catch { MessageBox.Show("Данные о почте неверны"); }
            }
            Class_for_db.closeconnection();


            

        }

    }
}
