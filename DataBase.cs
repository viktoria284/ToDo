using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace data_base
{
    internal class DataBase
    {
        //строка подключения 
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-TKHDSMUO\SQLEXPRESS;Initial Catalog=viki;Integrated Security=True");

        // методы, которые открывают закрывают связь с БД и возвращают строку подключения
        public void OpenConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
