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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDo
{
    public partial class Change : Form
    {
        DataBase database = new DataBase();
        private task TASK;
        public Change(task TASK)
        {
            this.TASK = TASK;
            InitializeComponent();
            CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_id.Text = TASK.TextBox_id;
            textBoxtask.Text = TASK.TextBox_task;
            textBox_des.Text = TASK.TextBox_desc;

            // Assuming TextBox_subject is a ComboBox
            

            if (TASK.isdone == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = textBox_id.Text;
            var name = textBoxtask.Text;
             
            var des = textBox_des.Text;
            var times = dateTimePicker1.Text;
            var don = checkBox1.Checked.ToString();






            var changequery = $"update tasks set task='{name}', task_desc = '{des}', deadline = '{times}', isdone = '{don}' where id_task = '{id}'";
            database.openConnection();
            var command = new SqlCommand(changequery, database.getConnection());
             
            


            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
             
        }

        private void textBoxtask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
