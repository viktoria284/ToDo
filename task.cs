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
    
 
        public class task
        {




            public string TextBox_id { get; set; }
            public string TextBox_task { get; set; }
            public ComboBox TextBox_subject { get; set; }
            public string TextBox_desc { get; set; }
             
            public string DateTimePicker_st_li { get; set; }
            public bool isdone { get; set; }
            public task(string id, string taskk, ComboBox sub,   string desc, string date, bool sa)
            {
                TextBox_id = id;
            TextBox_task = taskk;
            TextBox_subject = sub;
            TextBox_desc = desc;
                 
                DateTimePicker_st_li = date;
            isdone = sa;


            }


        }
    

}
