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

namespace ToDo
{
    public partial class login : Form
    {
        DataBase database = new DataBase();

        public login()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string Username = textBox_login.Text;
            string Password = textBox_password.Text;

            SqlDataAdapter adapetr = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user,password_user,access from register_2 where login_user = '{Username}' AND password_user = '{Password}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapetr.SelectCommand = command;
            adapetr.Fill(table);

            if (table.Rows.Count >= 1)
            {
                int accessValue = Convert.ToInt32(table.Rows[0]["access"]);

                User US;

                if (accessValue == 1)
                {
                    US = new Admin();
                }
                else
                {
                    US = new SimpleUser();
                }

                US.SetPropertiesFromDatabase(accessValue, textBox_login.Text, textBox_password.Text);

                // int t = Convert.ToInt32(table.Rows[0]["access"]);

                Main MAIN = new Main(US);

                this.Hide();
                MAIN.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "war!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void SignUpPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up sgn = new Sign_up();
            //this.Hide();
            sgn.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
