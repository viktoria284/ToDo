using data_base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            CenterToParent();
            textBox_password.PasswordChar = '*';
            textBox_password2.PasswordChar = '*';
        }
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login.Length < 5 || login.Length > 50)
            {
                MessageBox.Show("Логин должен содержать от 5 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length > 50)
            {
                MessageBox.Show("Пароль не должен содержать более 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != textBox_password2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckPasswordStrength(password))
            {
                return;
            }

            if (checkUser(login, password))
            {
                MessageBox.Show("Пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int access = checkBox1.Checked ? 1 : 0;
            password = HashPassword(textBox_password.Text);
            string querystring = $"INSERT INTO register_2 (login_user, password_user, access) VALUES ('{login}', '{password}', '{access}')";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            try
            {
                database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login frm_login = new login();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка при создании аккаунта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        private Boolean checkUser(string loginUser, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string qerystring = $"SELECT login_user,password_user,access from register_2 where login_user = '{loginUser}' and  password_user='{password}'";

            SqlCommand command = new SqlCommand(qerystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckPasswordStrength(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль слишком короткий. Пароль должен содержать не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну букву в верхнем регистре.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну букву в нижнем регистре.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void Sign_up_Load(object sender, EventArgs e)
        {
            if (ClassR.acf == 1)
            {
                checkBox1.Visible = true;
            }
        }

        private void LogInPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            // logIn log_in = new logIn(nameProgram);
            // this.Close();
            //log_in.Show();

        }
    }
}
