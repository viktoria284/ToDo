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
        public bool HasNotes { get; set; }

        public Subject(string name, string type, string teacher, string requirements, bool hasNotes)
        {
            Name = name;
            Type = type;
            Teacher = teacher;
            Requirements = requirements;
            HasNotes = hasNotes;
        }
    }
}
