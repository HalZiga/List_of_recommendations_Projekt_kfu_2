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
    public partial class Furniture : Form
    {
        public Furniture()
        {
            InitializeComponent();
        }

        private void pictureWStr5_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;
            pictureWStr5.Image = Resources.zvezda1;
        }

        private void pictureWStr4_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;

            pictureWStr5.Image = Resources.zvezda2;
        }

        private void pictureWStr3_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;

            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;
        }

        private void pictureWStr2_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;

            pictureWStr3.Image = Resources.zvezda2;
            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;
        }

        private void pictureWStr1_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;

            pictureWStr2.Image = Resources.zvezda2;
            pictureWStr3.Image = Resources.zvezda2;
            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;
        }



    }
}
