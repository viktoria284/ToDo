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

        //строка подключенния 
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=voevodov\SQLEXPRESS;Initial Catalog=viki;Integrated Security=True");


        // методы которые открывают  закрывают связь с БД и  возвращать строку подключени 
        public void openConnection()
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
