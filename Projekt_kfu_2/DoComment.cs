using Projekt_kfu_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_kfu_2
{
    public partial class DoComment : Form
    {
        private int IdFurn;
        private int Mark;
        public DoComment()
        {
            InitializeComponent();
             
        }
        public DoComment(int id)
        {
            InitializeComponent();
            IdFurn = id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Mark != 0)
            {
                Class_for_db.Connect();
                Class_for_db.openconnection();

                var summarks = new SqlCommand($"select max(SumMarks) from [Furniture] where FurnitureId = '{IdFurn}' ;", Class_for_db.UserSqlConnection());
                var countmarks = new SqlCommand($"select max(CountMarks) from [Furniture] where FurnitureId = '{IdFurn}' ;", Class_for_db.UserSqlConnection());
                //var midmarks = new SqlCommand($"select IsNull(midMarks,0) from [Furniture] where FurnitureId = '{IdFurn}' ;", Class_for_db.UserSqlConnection());

                int ssummarks = (int)summarks.ExecuteScalar();
                int ccountmarks = (int)countmarks.ExecuteScalar();
                //var mmidmarks = (double)midmarks.ExecuteScalar();


                ssummarks += Mark;
                ccountmarks++;



                float mmidmarks = ((float)ssummarks / (float)ccountmarks);




                SqlCommand command = new SqlCommand($"UPDATE [Furniture] SET SumMarks = '{ssummarks}', CountMarks = '{ccountmarks}', midMarks = '{mmidmarks}' WHERE FurnitureId = '{IdFurn}'", Class_for_db.UserSqlConnection());
                int A = command.ExecuteNonQuery();
                

                Class_for_db.closeconnection();
            }
        }

        private void pictureWStr1_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;

            pictureWStr2.Image = Resources.zvezda2;
            pictureWStr3.Image = Resources.zvezda2;
            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;

            Mark = 1;


        }

        private void pictureWStr2_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;

            pictureWStr3.Image = Resources.zvezda2;
            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;
            Mark = 2;
        }

        private void pictureWStr3_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;

            pictureWStr4.Image = Resources.zvezda2;
            pictureWStr5.Image = Resources.zvezda2;

            Mark = 3;
        }

        private void pictureWStr4_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;

            pictureWStr5.Image = Resources.zvezda2;

            Mark = 4;
        }

        private void pictureWStr5_Click(object sender, EventArgs e)
        {
            pictureWStr1.Image = Resources.zvezda1;
            pictureWStr2.Image = Resources.zvezda1;
            pictureWStr3.Image = Resources.zvezda1;
            pictureWStr4.Image = Resources.zvezda1;
            pictureWStr5.Image = Resources.zvezda1;
            Mark = 5;
        }

        private void DoComment_Load(object sender, EventArgs e)
        {

        }
    }
}
