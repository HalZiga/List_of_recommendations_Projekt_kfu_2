using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

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
    }
    
}
