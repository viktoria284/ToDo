using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.CodeDom.Compiler;
using data_base;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
 using System.Windows.Forms;




namespace ToDo
{
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,

    }

    public partial class main : Form
    {
        private System.Timers.Timer timer;
        private DateTime startTime;
        int onec = 0;
        DataBase database = new DataBase();
        int selectedRow; int selectedRow2;
        int Id_done;
        string Id_subs;
        public main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1 секунда
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Tick);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            label1.Text = $"{elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";
        }
        private void CreateColums()
        {

            dataGridView1.Columns.Add("subject_name", "id");

            dataGridView1.Columns.Add("subject_name", "subject_name");
            dataGridView1.Columns.Add("type_subject", "type_subject");
            dataGridView1.Columns.Add("teachers", "teachers");
            dataGridView1.Columns.Add("requirements", "requirements");
            dataGridView1.Columns.Add("notes", "notes");

        }
        private void CreateColums_2()
        {
            dataGridView2.Columns.Add("id_task", "id_task");
            dataGridView2.Columns.Add("task", "task");
            dataGridView2.Columns.Add("subject_name", "subject_name");

            dataGridView2.Columns.Add("task_desc", "task_desc");
            dataGridView2.Columns.Add("deadline", "deadline");
            dataGridView2.Columns.Add("isdone", "isdone");

        }
        private void ReadSingleRow(DataGridView dvg, IDataRecord record)
        {

            int id_subject = record.GetInt32(0);
            string subject_name = record.GetString(1);
            string type_subject = record.GetString(2);
            string teachers = record.GetString(3);
            string requirements = record.GetString(4);
            string notes = record.GetString(5);

            bool isNew = true;

            dvg.Rows.Add(id_subject, subject_name, type_subject, teachers, requirements, notes);




        }

        private void ReadSingleRow2(DataGridView dvg, IDataRecord record)
        {

            int id_task = record.GetInt32(0);
            string task = record.GetString(1);
            string subject_name = record.GetString(2);
            string task_desc = record.GetString(3);
            DateTime deadline = record.GetDateTime(4);
            bool isdone = record.GetBoolean(5);



            dvg.Rows.Add(id_task, task, subject_name, task_desc, deadline, isdone, RoWState.ModifiedNew.ToString());
              if (isdone == true)
            {
                foreach (DataGridViewCell cell in dvg.Rows[dvg.Rows.Count - 1].Cells)
                {
                    cell.Style.BackColor = Color.SpringGreen;
                }
            }
            
            else if (deadline < dateTimePicker2.Value      /*  dateTimePicker1.Value*/)
            {
                // Если срок годности истек, устанавливаем цвет фона строки на красный.
                foreach (DataGridViewCell cell in dvg.Rows[dvg.Rows.Count - 1].Cells)
                {
                    cell.Style.BackColor = Color.IndianRed;
                }
            }
             
            else if (deadline < dateTimePicker2.Value & isdone == true  /* dateTimePicker1.Value.AddDays(1)*/)
            {
                // Если срок годности истекает через день, устанавливаем цвет фона строки на желтый.
                foreach (DataGridViewCell cell in dvg.Rows[dvg.Rows.Count - 1].Cells)
                {
                    cell.Style.BackColor = Color.Green;
                }
            }
            else if (deadline == dateTimePicker2.Value  /* dateTimePicker1.Value.AddDays(1)*/)
            {
                // Если срок годности истекает через день, устанавливаем цвет фона строки на желтый.
                foreach (DataGridViewCell cell in dvg.Rows[dvg.Rows.Count - 1].Cells)
                {
                    cell.Style.BackColor = Color.Yellow;
                }
            }
             



        }



        private void RefreshDataGrid(DataGridView dvg)
        {





            dvg.Rows.Clear();
            string queryString;
            string selectedValue = comboBox1.SelectedValue.ToString();
            if (selectedValue == "ALL" || selectedValue == null)

            {
                queryString = $"select * from subjects  ";
            }
            else
            {
                queryString = $"select * from subjects where subject_name = '{selectedValue}'";

            }
            using (SqlCommand command = new SqlCommand(queryString, database.getConnection()))
            {
                database.openConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReadSingleRow(dvg, reader);
                    }

                    reader.Close(); // Закрываем DataReader, чтобы освободить ресурсы
                }

                database.closeConnection();
            }
        }
        private void RefreshDataGrid2(DataGridView dvg)
        {

            dvg.Rows.Clear();

            string queryString = $"select * from tasks where subject_name = '{Id_subs}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                ReadSingleRow2(dvg, reader);

            }
            reader.Close();


        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;




            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];


                Id_subs = (string)row.Cells[1].Value;
            }
            RefreshDataGrid2(dataGridView2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow2 = e.RowIndex;




            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow2];

                Id_done = Convert.ToInt32(row.Cells[0].Value);

                // Получите id из выделенной строки и передайте его в метод showPicture
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillComboBox();
            CreateColums();
            CreateColums_2();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2); FillComboBox();

            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);




        }

        private void FillComboBox()
        {
            try
            {
                string query = "SELECT subject_name FROM subjects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, database.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Выводим содержимое DataTable в консоль (для отладки)
                Console.WriteLine("DataTable Content:");
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        Console.Write($"{col.ColumnName}: {row[col]}, ");
                    }
                    Console.WriteLine();
                }

                // Или используем MessageBox.Show для вывода содержимого DataTable
                // MessageBox.Show(table.Rows.Count.ToString());

                comboBox1.DisplayMember = "subject_name";
                comboBox1.ValueMember = "subject_name";
                comboBox1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);
        }
        public ComboBox MyComboBox
        {
            get
            {
                return comboBox1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Stop();
            label1.Text = "00:00:00";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aDDSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

        }






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            combo.boxes = comboBox1;
            add ADS = new add();
            ADS.ShowDialog();

        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RoWState.Deleted;
                return;

            }
            dataGridView1.Rows[index].Cells[6].Value = RoWState.Deleted;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedValue.ToString();
            database.openConnection();

            var task = textBox1.Text;
            var name = selectedValue;
            var desc = textBox3.Text;
            bool lw = false;
            var temess = dateTimePicker1.Value;
            var addQuery = "INSERT INTO tasks (task,subject_name, task_desc, deadline,isdone) " +
                           "VALUES (@task, @name, @desc, @time,@done)";

            using (var command = new SqlCommand(addQuery, database.getConnection()))
            {
                // Adding parameters with proper names
                command.Parameters.AddWithValue("@task", task);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@desc", desc);
                command.Parameters.AddWithValue("@time", temess);
                command.Parameters.AddWithValue("@done", lw);


                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            database.closeConnection();

        }

        private void button9_Click(object sender, EventArgs e)
        {










            var changequery = $"update tasks set isdone ='{true}' where id_task = '{Id_done}' ";
            database.openConnection();
            var command = new SqlCommand(changequery, database.getConnection());





            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();





























        }

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.getConnection();
            
                var id = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[0].Value);

            var DeleteQuery = $"delete from subjects where  subject_name = '{Id_subs}' ";


            var command = new SqlCommand(DeleteQuery, database.getConnection());
                command.ExecuteNonQuery();

                database.closeConnection();
             
        }

        private void delete_Click(object sender, EventArgs e)
        {
            database.getConnection();
            {
                var id = Convert.ToInt32(dataGridView2.Rows[selectedRow2].Cells[0].Value);

                var DeleteQuery = $"delete from tasks where id_task = {Id_done} ";

                var command = new SqlCommand(DeleteQuery, database.getConnection());
                command.ExecuteNonQuery();

                database.closeConnection();
            }
        }

        private void button7_Click(object sender, EventArgs e, main main)
        {
           this.Width = 1310;
             
        }
    }
}