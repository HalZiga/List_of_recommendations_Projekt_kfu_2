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
            user.Show();
            textBoxName.Text = "Имя";
            textBoxName.ForeColor = Color.Gray;
            textBoxSurname.Text = "Фамилия";
            textBoxSurname.ForeColor = Color.Gray;
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
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Имя";
                textBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Имя")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                textBoxSurname.Text = "Фамилия";
                textBoxSurname.ForeColor = Color.Gray;
            }
        }

        private void textBoxSurname_Enter(object sender, EventArgs e)
        {
            if (textBoxSurname.Text == "Фамилия")
            {
                textBoxSurname.Text = "";
                textBoxSurname.ForeColor = Color.Black;
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

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            /*
            DB db = new DB();
            // Получаем данные от пользователя
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            name_user = loginUser;
            db.openConnection();
            try
            {
                var uncid = "121212"; // Пользовательский код
                var unicEng = "140408";
                var unicAdm = "080414";
                var name = new SqlCommand($"select max(Name) from users where login = '{loginUser}' ;", db.getConnection());
                var Lastname = new SqlCommand($"select max(LastName) from users where login = '{loginUser}' ;", db.getConnection());
                var email = new SqlCommand($"select max(email) from users where login = '{loginUser}' ;", db.getConnection());
                var unic_id = new SqlCommand($"select max(unic_id) from users where login = '{loginUser}' ;", db.getConnection());
                var user_id = new SqlCommand($"select max(user_id) from users where login = '{loginUser}' ;", db.getConnection());
                var userr_id = (int)user_id.ExecuteScalar();
                var unic_idd = (string)unic_id.ExecuteScalar();
                var namme = (string)name.ExecuteScalar();
                var LastNamee = (string)Lastname.ExecuteScalar();
                var emaiil = (string)email.ExecuteScalar();
                //Создаем обьект класса нашей базы данных

                DataTable table = new DataTable();


                //Команда которая должна выполнится для базы данных
                var log = loginUser;
                var pas = passUser;

                SqlCommand cmd = new SqlCommand($"select count(*) from users where login = '{log}' and password = '{pas}'", db.getConnection());
                db.openConnection();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0 && unic_idd == uncid)
                {
                    this.Hide();
                    var val = new FormUser(namme, loginUser, emaiil, LastNamee, userr_id, unic_idd);
                    val.ShowDialog();
                }
                else if (count > 0 && unic_idd == unicEng)
                {
                    this.Hide();
                    var val = new FormEngineer2(namme, loginUser, emaiil, LastNamee, userr_id, unic_idd);
                    val.ShowDialog();
                }
                else if (count > 0 && unic_idd == unicAdm)
                {
                    this.Hide();
                    var val = new AdminForm(namme, loginUser, emaiil, LastNamee, userr_id, unic_idd);
                    val.ShowDialog();
                }
                else { MessageBox.Show("Введенные данные неверны"); }
            }
            catch { MessageBox.Show("Возникла ошибка"); }
            db.closeConnection();*/
            
        }
    }
    
}
