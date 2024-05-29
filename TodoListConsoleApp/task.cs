using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListConsoleApp
{
    internal class task
    {
        private string Name;
        private string Description;

        public task(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string getTaskName()
        {
            return Name;
        }

        public string getDescription()
        {
            return Description;
        }
    }
}
