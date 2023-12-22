using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Teacher { get; set; }
        public string Requirements { get; set; }
        public string Notes { get; set; }

        public Subject(string name, string type, string teacher, string requirements, string notes)
        {
            Name = name;
            Type = type;
            Teacher = teacher;
            Requirements = requirements;
            Notes = notes;
        }
    }
}
