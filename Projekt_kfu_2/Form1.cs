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

namespace Projekt_kfu_2
{
    public partial class Avtorisation : Form
    {


        static Point pointPassword = new Point(0,0); //ебусь с бесполезными координатами переделаю
        public Avtorisation()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.userr = user;
            user.Show();

            textBoxLogin.Text = "Логин";
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPassword.Text = "Пароль";
            textBoxPassword.ForeColor = Color.Gray;
            textBoxPassword.PasswordChar = '*';
            pictureBoxVisible.Visible = false;


            int centerX = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int centerY = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(centerX, centerY);

            pointPassword = textBoxPassword.Location;//ебусь с бесполезными координатами переделаю


        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логин")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }


        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxHide.Visible = false;
            pictureBoxVisible.Visible = true;
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Visible = true;
            pictureBoxVisible.Visible = false;
        }

        private void Avtorisation_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Avtorisation_ResizeEnd(object sender, EventArgs e)
        {
            //ебусь с бесполезными координатами переделnm надо или удалить
            pointPassword.X = (pointPassword.X   + 193);
            pictureBoxHide.Location = pointPassword;
            pointPassword.X = textBoxPassword.Location.X;
        }

        private void buttonRegestration_Click(object sender, EventArgs e)
        {

            Regestration regestration = new Regestration();
            regestration.Show();
        }

        public void buttonEntrance_Click(object sender, EventArgs e)
        {
            Class_for_db.Connect();
            Class_for_db.openconnection();

            // Получаем данные от пользователя
            String loginUser = textBoxLogin.Text;
            String passUser = textBoxPassword.Text;


            

            var name = new SqlCommand($"select max(Name) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            var surname = new SqlCommand($"select max(Surname) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            var Lastname = new SqlCommand($"select max(LastName) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            var email = new SqlCommand($"select max(Email) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            var user_id = new SqlCommand($"select max(UserId) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());

            var userr_id = (int)user_id.ExecuteScalar();
            var namme = (string)name.ExecuteScalar();
            var surnamme = (string)surname.ExecuteScalar();
            var LastNamee = (string)Lastname.ExecuteScalar();
            var emaiil = (string)email.ExecuteScalar();
            //Создаем обьект класса нашей базы данных

            DataTable table = new DataTable();


            //Команда которая должна выполнится для базы данных
            var log = loginUser;
            var pas = passUser;

            SqlCommand cmd = new SqlCommand($"select count(*) from [Table] where login = '{log}' and password = '{pas}'", Class_for_db.UserSqlConnection());

            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                this.Hide();
                //var val = new FormUser(namme, loginUser, emaiil, LastNamee, userr_id, unic_idd);
                //val.ShowDialog();
            }
            else { MessageBox.Show("Введенные данные неверны"); }
            
            //catch { MessageBox.Show("Возникла ошибка"); }
            Class_for_db.closeconnection();

        }


    }
    
}
