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
using System.Drawing;

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

        public static int AddUser(string name, string surname, string lastName, string email, string password, string login)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Table] (Name, Surname, LastName, Email, Password, Login) VALUES (N'{name}',N'{surname}',N'{lastName}', '{email}', '{password}', '{login}')", SqlConnection_connection);
            int A = command.ExecuteNonQuery();
            return A;
        }

        public static int AddFurnitur(string fname, string fdescription,string type,int foto)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Furniture] (FName, FDescription,Type,Foto) VALUES (N'{fname}',N'{fdescription}', N'{type}', N'{foto}')", SqlConnection_connection);
            int A = command.ExecuteNonQuery();
            return A;
        }
        public static int AddFurnitur(string fname, string fdescription, string type)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Furniture] (FName, FDescription,Type) VALUES (N'{fname}', N'{fdescription}', N'{type}')", SqlConnection_connection);
            int A = command.ExecuteNonQuery();
            if (A == 1)
            {
                MessageBox.Show($"{A}");
            }
            return A;
        }
        public static Boolean UserExist(string login)
        {
            DataTable table = new DataTable();

            //создали адаптер котор будет выполнять наши запросы в будущем
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"select * from [Table] where Login LIKE  N'{login}' ", SqlConnection_connection);

            //Выбрали и выполнили нужную команду
            adapter.SelectCommand = command;

            //Помещаем в table
            adapter.Fill(table);


            //Проверка на существование пользователя
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                
                return true;
            }
            else { return false; }

        }

        /*public static int UserId(string name, string surname, string lastName) в итоге не нужен, но способ для считывания конкретного значения пусть останется
        {
            if (lastName.Equals("Отчество(если имеется)"))
            {
                lastName = "";
            }
            DataTable table = new DataTable();

            //создали адаптер котор будет выполнять наши запросы в будущем
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"select UserId Name, Surname, LastName from [Table] where Name LIKE  N'{name}' AND Surname LIKE N'{surname}' AND LastName LIKE N'{lastName}'", SqlConnection_connection);

            //Выбрали и выполнили нужную команду
            adapter.SelectCommand = command;

            //Помещаем в table
            adapter.Fill(table);
            var ID = table.Rows[0].ItemArray[0];

            return (int)ID;
        }*/
        public static SqlConnection UserSqlConnection()
        {
            return SqlConnection_connection;

        }
    }
}
