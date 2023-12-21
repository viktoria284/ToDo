using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public class Task
    {
        public string TextBox_id { get; set; } //int ??
        public string TextBox_task { get; set; }
        public string TextBox_desc { get; set; }
        public string DateTimePicker { get; set; }
        public bool isDone { get; set; }
        public Task(string id, string task, string desc, string date, bool isd)
        {
            TextBox_id = id;
            TextBox_task = task;
            TextBox_desc = desc;
            DateTimePicker = date;
            isDone = isd;
        }
    }
}