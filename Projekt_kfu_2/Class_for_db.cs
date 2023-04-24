using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Projekt_kfu_2
{
    internal static class Class_for_db
    {
        private static SqlConnection SqlConnection_connection = null;

        public static void Connect()
        {
            SqlConnection_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseUser"].ConnectionString);

        }

        public static void openconnection()
        {
            if(SqlConnection_connection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection_connection.Open ();
            }
        }
        public static void closeconnection()
        {
            if (SqlConnection_connection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection_connection.Close();
            }
        }

        public static int AddUser(string name, string surname, string lastName, string email, string password)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Table] (Name, Surname, LastName, Email, Password) VALUES (N'{name}',N'{surname}',N'{lastName}', '{email}', '{password}')", SqlConnection_connection);
            int A = command.ExecuteNonQuery();
            MessageBox.Show($"{A}");
            return A;


        }

        public static Boolean UserExist(string name, string surname, string lastName)
        {
            if (lastName.Equals("Отчество(если имеется)"))
            {
                lastName = "";
            }
            DataTable table = new DataTable();

            //создали адаптер котор будет выполнять наши запросы в будущем
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"select Name, Surname, LastName from [Table] where Name LIKE  N'{name}' AND Surname LIKE N'{surname}' AND LastName LIKE N'{lastName}'", SqlConnection_connection);

            //Выбрали и выполнили нужную команду
            adapter.SelectCommand = command;

            //Помещаем в table
            adapter.Fill(table);

            //Проверка на существование пользователя
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже существует");
                return true;
            }
            else { return false; }
        }


    }
}
