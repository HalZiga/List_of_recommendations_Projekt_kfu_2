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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Projekt_kfu_2
{
    public partial class AddFurn : Form
    {
        private bool Exep = false;
        public AddFurn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class_for_db.Connect();
            Class_for_db.openconnection();
            if (Exep)
            {
                int fot = TouchScroll.Addd(pictureBoxAdd.Image);
                if (Class_for_db.AddFurnitur(textBoxFName.Text,textBoxFDescription.Text, comboBox1.Text, fot) == 1)
                {

                }

            }
            else
            {
                Class_for_db.AddFurnitur(textBoxFName.Text, textBoxFDescription.Text, comboBox1.Text);
            }
            Class_for_db.closeconnection();

            //openFileDialog1.ShowDialog();
            //pictureBoxAdd.ImageLocation = openFileDialog1.FileName;
            //this.Text = openFileDialog1.FileName;
            //System.Drawing.Image img = System.Drawing.Image.FromFile(Text);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

        }
        

        private void AddFurn_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Характеристики";
            comboBox1.ForeColor = Color.Gray;
            textBoxFName.Text = "Название";
            textBoxFName.ForeColor = Color.Gray;
            textBoxFDescription.Text = "Описание";
            textBoxFDescription.ForeColor = Color.Gray;
        }



        private void textBoxFName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFName.Text))
            {
                textBoxFName.Text = "Название";
                textBoxFName.ForeColor = Color.Gray;
            }
        }

        private void textBoxFName_Enter(object sender, EventArgs e)
        {
            if (textBoxFName.Text.Equals("Название"))
            {
                textBoxFName.Text = "";
                textBoxFName.ForeColor = Color.Black;
            }
        }

        private void textBoxFDescription_Enter(object sender, EventArgs e)
        {
            if (textBoxFDescription.Text.Equals("Описание"))
            {
                textBoxFDescription.Text = "";
                textBoxFDescription.ForeColor = Color.Black;
            }
        }

        private void textBoxFDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFDescription.Text))
            {
                textBoxFDescription.Text = "Описание";
                textBoxFDescription.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Характеристики"))
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                comboBox1.Text = "Характеристики";
                comboBox1.ForeColor = Color.Gray;
            }
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;| All Files(*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxAdd.Image = new Bitmap(ofd.FileName);
                    Exep = true;
                }
                catch 
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
