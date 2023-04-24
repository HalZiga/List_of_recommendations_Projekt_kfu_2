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

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Koord(this.Location);
            Koord(buttonMenu.Location);

            MenuL menuL = MenuL.Getinstatnce();
            menuL.Location = User.pointMenu;
            menuL.Show();
            menuL.BringToFront();





            pointMenu = new Point(0, 0);

        }
    }
}
