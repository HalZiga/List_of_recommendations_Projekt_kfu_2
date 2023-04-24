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
    
    public partial class User : Form
    {
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

            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;

            menuStrip1.Padding = new System.Windows.Forms.Padding(0);

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Koord(this.Location);
            Koord(buttonMenu.Location);

            MenuL menuL = MenuL.Getinstatnce(userr);
            menuL.Location = User.pointMenu;
            menuL.Show();
            menuL.BringToFront();

            pointMenu = new Point(0, 0);

        }
        private void OpenChildForm(Form childform, object btnSender)//в идеале надо изменить на приват
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void информацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProgrInfo(), sender);
        }
    }
}
