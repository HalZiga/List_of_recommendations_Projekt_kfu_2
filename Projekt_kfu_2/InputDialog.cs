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
    public partial class InputDialog : Form
    {
        public bool Flag = false;

        public string InputText { get; private set; }
        public bool IsOkClicked { get; private set; }
        public InputDialog()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            InputText = textBox1.Text;
            if (InputText == "836852")
            {
                IsOkClicked = true;
                Flag = true;
            }
            else
            {
                Flag = false;
                IsOkClicked = false;
                MessageBox.Show("Код введен неправильно, возможно вы неверно указали почту");
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputText = "";
            IsOkClicked = false;
            Close();
        }

    }
}
