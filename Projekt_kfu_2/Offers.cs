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
    public partial class Offers : Form
    {
        public Offers()
        {
            InitializeComponent();
        }

        private void Offers_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Padding= new System.Windows.Forms.Padding(5, 5, 5, 5);

            populayeItems();
        }

        private void populayeItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i< 10; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Message = "НУ тут будет имя";

                if(flowLayoutPanel1.Controls.Count < 0) 
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }
        }
    }
}
