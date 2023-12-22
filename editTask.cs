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
    public partial class editTask : Form
    {
        DataBase database = new DataBase();
        private Task TASK;
        public editTask(Task TASK)
        {
            this.TASK = TASK;
            InitializeComponent();
            CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox_id.Text = TASK.TaskId;
            textBoxtask.Text = TASK.TaskName;
            textBox_des.Text = TASK.TaskDesc;

            // Assuming TextBox_subject is a ComboBox
            if (TASK.isDone == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void AcceptChangesButtonClick(object sender, EventArgs e)
        {
            var id = textBox_id.Text;
            var name = textBoxtask.Text;

            var des = textBox_des.Text;
            var times = dateTimePicker1.Text;
            var don = checkBox1.Checked.ToString();

            var changequery = $"update tasks set task='{name}', task_desc = '{des}', deadline = '{times}', isdone = '{don}' where id_task = '{id}'";
            database.OpenConnection();
            var command = new SqlCommand(changequery, database.GetConnection());

            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.CloseConnection();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
