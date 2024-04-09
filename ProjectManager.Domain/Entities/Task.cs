using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Entities
{
    public class Task
    {
        public string Name { get; set; }
        public double PercentCompleted { get; set; }

        public Task(string name, double percentCompleted)
        {
            Name = name;
            PercentCompleted = percentCompleted;
        }
    }
}
