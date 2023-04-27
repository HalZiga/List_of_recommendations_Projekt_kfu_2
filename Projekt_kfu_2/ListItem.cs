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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private void pictureWStr1_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;

            pictureWStr2.Image = Resources.zvezda2;
            pictureWStr3.Image = Resources.zvezda2;
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

        private void pictureWStr3_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;

            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;
        }

        private void pictureWStr4_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;

            pictureWStr5.Image = Resources.zvezda2;
        }

        private void pictureWStr5_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;
            pictureWStr5.Image = Resources.zvezda1;
        }

        #region Properties
        private Image _icon;
        private string _message;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }
        #endregion
    }
}
