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
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        main mainInstance = new main();
       
        
        
        
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }
         

         

        // Используйте свойство для доступа к элементу
         
        private void button1_Click(object sender, EventArgs e)
        {


            database.openConnection();

            var name = textBox1.Text;
            var type = textBox2.Text;
            var teacher = textBox3.Text;
            var req = textBox4.Text;
            var notes = textBox5.Text;

            var addQuery = "INSERT INTO subjects (subject_name, type_subject, teachers, requirements, notes) " +
                           "VALUES (@name, @type, @teacher, @req, @notes)";

            using (var command = new SqlCommand(addQuery, database.getConnection()))
            {
                // Adding parameters with proper names
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@teacher", teacher);
                command.Parameters.AddWithValue("@req", req);
                command.Parameters.AddWithValue("@notes", notes);

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
