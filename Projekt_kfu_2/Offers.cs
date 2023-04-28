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
    public partial class Offers : Form
    {
        public Offers()
        {
            InitializeComponent();
        }

        private void Offers_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Padding= new System.Windows.Forms.Padding(5, 5, 5, 5);


            Class_for_db.Connect();
            Class_for_db.openconnection();




            // SqlCommand command = new SqlCommand($"select FurnitureId,midMarks from [Furniture] where Login LIKE  N'{login}' ",Class_for_db.UserSqlConnection());

            populayeItems();
        }

        private void populayeItems()
        {
            Class_for_db.Connect();
            Class_for_db.openconnection();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT FurnitureId FROM Furniture order by midMarks DESC",Class_for_db.UserSqlConnection());
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // получаем все ячейки строки
                    var cells = row.ItemArray;
                    int coun = cells.Length;
                    int A = 0;
                    ListItem[] listItems = new ListItem[coun];
                    foreach (int cell in cells)
                    {
                        var fName = new SqlCommand($"select FName from [Furniture] where FurnitureId = '{cell}' ;", Class_for_db.UserSqlConnection());
                        var midmarks = new SqlCommand($"select IsNull(midMarks,0) from [Furniture] where FurnitureId = '{cell}' ;", Class_for_db.UserSqlConnection());


                        string ffName = (string)fName.ExecuteScalar();
                        double mmidmarks = Convert.ToDouble(midmarks.ExecuteScalar());

                        //MessageBox.Show($"{ffName}");
                        //MessageBox.Show($"{mmidmarks}");


                        listItems[A] = new ListItem();
                        listItems[A].Message = ffName;
                        listItems[A].Mark = Math.Round(mmidmarks, 2);
                        listItems[A].ID = cell;



                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(listItems[A]);
                        }
                        A++;

                    }


                }
            }

                

            //for (int i = 0; i< 10; i++)
            //{
            //    listItems[i] = new ListItem();
            //    listItems[i].Message = "НУ тут будет имя";

            //    if(flowLayoutPanel1.Controls.Count < 0) 
            //    {
            //        flowLayoutPanel1.Controls.Clear();
            //    }
            //    else
            //    {
            //        flowLayoutPanel1.Controls.Add(listItems[i]);
            //    }
            //}
        }
    }
}
