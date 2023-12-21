using data_base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ToDo
{
    public partial class AddSub : Form
    {
        DataBase database = new DataBase();
         
       
        
        
        
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }

        // Используйте свойство для доступа к элементу

        private void AddSubjectButtonClick(object sender, EventArgs e)
        {
            database.OpenConnection();

            // Получаем данные из текстовых полей формы
            var name = textBox1.Text;
            var type = textBox2.Text;
            var teacher = textBox3.Text;
            var req = textBox4.Text;
            var notes = textBox5.Text;

            // Создаем экземпляр класса Subject
            Subject subject = new Subject(name, type, teacher, req, !string.IsNullOrEmpty(notes));

            // Используем параметризованный SQL-запрос с использованием данных из экземпляра Subject
            var addQuery = "INSERT INTO subjects (subject_name, type_subject, teachers, requirements, notes) " +
                           "VALUES (@name, @type, @teacher, @req, @notes)";

            using (var command = new SqlCommand(addQuery, database.GetConnection()))
            {
                // Добавляем параметры с правильными именами
                command.Parameters.AddWithValue("@name", subject.Name);
                command.Parameters.AddWithValue("@type", subject.Type);
                command.Parameters.AddWithValue("@teacher", subject.Teacher);
                command.Parameters.AddWithValue("@req", subject.Requirements);
                command.Parameters.AddWithValue("@notes", subject.HasNotes);

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            database.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
