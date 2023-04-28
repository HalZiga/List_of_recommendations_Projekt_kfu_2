using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_kfu_2
{

    public partial class User : Form
    {
        public static void hidde()
        {
            
        }
        public User userr = null;

        private Form activrForm;

        public static Point pointMenu = new Point(0, 0);
        public static void Koord(Point A)
        {
            pointMenu.X += A.X;
            pointMenu.Y += A.Y;
        }
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);

            

            menuStrip1.Padding = new System.Windows.Forms.Padding(0);

            //Таймер для входа
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            //Koord(this.Location);
            //Koord(buttonMenu.Location); кучу времени потратил на правильную локацию обиндо просто убирать пусть останется вдруг в будущем нужен будет


            MenuL menuL = MenuL.Getinstatnce(userr);
            menuL.Location = User.pointMenu;
            menuL.Show();
            menuL.BringToFront();

            pointMenu = new Point(0, 0);

        }
        private void OpenChildForm(Form childform, object btnSender)
        {
            if(activrForm != null)
            {
                activrForm.Close();
            }
            activrForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childform);
            this.panelDesktopPane.Tag= childform;
            childform.BringToFront();
            childform.Show();
            //labelforForm.Text = childform.Text;
        }





        private void оПриложенииToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormProgrInfo(), sender);
            labelforForm.Text = "О приложении";
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Avtorisation avtorisation = Avtorisation.Getinstatnce();
            avtorisation.Show();

        }


        private void предложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Class_for_db.Connect();
            //Class_for_db.openconnection();

            //DataTable table = new DataTable();

            //var name = new SqlCommand($"select * from [Furniture] order by CustomerID DESC ;", Class_for_db.UserSqlConnection());
            //var surname = new SqlCommand($"select max(Surname) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            //var Lastname = new SqlCommand($"select max(LastName) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            //var email = new SqlCommand($"select max(Email) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());
            //var user_id = new SqlCommand($"select max(UserId) from [Table] where Login = '{loginUser}' ;", Class_for_db.UserSqlConnection());

            //var userr_id = (int)user_id.ExecuteScalar();
            //var namme = (string)name.ExecuteScalar();
            //var surnamme = (string)surname.ExecuteScalar();
            //var LastNamee = (string)Lastname.ExecuteScalar();
            //var emaiil = (string)email.ExecuteScalar();

            OpenChildForm(new Offers(), sender);
            labelforForm.Text = "Предложения";
        }
    }
}
