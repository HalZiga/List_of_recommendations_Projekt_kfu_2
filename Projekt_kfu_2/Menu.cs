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
    public partial class MenuL : Form
    {
        static MenuL menu = null;
        private User user1 = new User();

        private MenuL()
        {
            InitializeComponent();
        }
        private MenuL(User user)
        {
            InitializeComponent();
            user1 = user;
        }

        public static MenuL Getinstatnce(User user) 
        {
            if (menu == null) 
            {
               menu = new MenuL(user);
            }
            return menu;

        }

        private void MenuL_Load(object sender, EventArgs e)
        {
            this.Location = User.pointMenu;

            this.FormBorderStyle= FormBorderStyle.None;//уюираю крестик сверху

            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonInformation.FlatAppearance.BorderSize = 0;
            buttonInformation.FlatStyle = FlatStyle.Flat;

            tableLayoutPanel1.Margin= new System.Windows.Forms.Padding(0);//рестояние в табле

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            
        }

    }
}
