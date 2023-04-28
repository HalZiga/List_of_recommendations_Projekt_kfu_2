using Projekt_kfu_2.Properties;
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
    public partial class RegistUser : Form
    {
        private Form activrForm;
        private int UsId;
        public RegistUser()
        {
            InitializeComponent();
        }
        public RegistUser(int usid)
        {
            InitializeComponent();
            this.UsId = usid;
        }

        private void RegistUser_Load(object sender, EventArgs e)
        {

            pictureBoxMenu.Hide();
            //button1.BackgroundImage = Resources.free_icon_sofa_2146347;
            
            button1Menu.FlatAppearance.BorderSize = 0;
            button1Menu.FlatStyle = FlatStyle.Flat;
            button2Menu.FlatAppearance.BorderSize = 0;
            button2Menu.FlatStyle = FlatStyle.Flat;
            button3Menu.FlatAppearance.BorderSize = 0;
            button3Menu.FlatStyle = FlatStyle.Flat;


            panel4.Margin = new System.Windows.Forms.Padding(0);
            panel4.Padding = new System.Windows.Forms.Padding(0);
        }

        bool sidebarExpand;

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand= false;
                    SidebarTimer.Stop();
                    label1.Hide();
                    pictureBoxMenu.Show();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand= true;
                    SidebarTimer.Stop();
                    pictureBoxMenu.Hide();
                    label1.Show();
                }

            }
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            SidebarTimer.Start();

        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var add = new AddFurn(UsId);
            add.ShowDialog();
        }

        private void button1Menu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Offers(), sender);
            labelforForm.Text = "Предложения";
        }
        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activrForm != null)
            {
                activrForm.Close();
            }
            activrForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childform);
            this.panelDesktopPane.Tag = childform;
            childform.BringToFront();
            childform.Show();
            //labelforForm.Text = childform.Text;
        }
    }
}
