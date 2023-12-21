using data_base;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToDo
{
    public partial class Sign_up : Form
    {

        DataBase database = new DataBase();
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkuser() == false)
            {




                if (textBox_password.Text == "" || textBox_login.Text == "" || (textBox_password.Text == "" && textBox_login.Text == ""))
                {
                    MessageBox.Show("Заполните все поля", "errore");
                }
                else
                {

                    var login = textBox_login.Text;
                    var password = textBox_password.Text;
                    int access;
                    if (checkBox1.Checked == true)
                    {
                        access = 1;
                    }
                    else
                    {
                        access = 0;
                    }


                    string querystring = $"insert into register_2(login_user,password_user,access) values ('{login}', '{password}','{access}')";

                    SqlCommand command = new SqlCommand(querystring, database.getConnection());


                    database.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан", "succses!");
                        login frm_login = new login();
                        this.Hide();
                        frm_login.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("errore");
                    }
                    database.closeConnection();


                }
            }
            else
            {
                return;
            }


        }
        private Boolean checkuser()
        {
            var loginUser = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string qerystring = $"select login_user,password_user,access from register_2 where login_user = '{loginUser}' and  password_user='{password}'";

            SqlCommand command = new SqlCommand(qerystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("пользоваткель уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }
    }
}
