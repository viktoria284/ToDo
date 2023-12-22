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
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public string DateTimePicker { get; set; }
        public bool isDone { get; set; }
        public Task(string id, string task, string desc, string date, bool isd)
        {
            TaskId = id;
            TaskName = task;
            TaskDesc = desc;
            DateTimePicker = date;
            isDone = isd;
        }
    }
}