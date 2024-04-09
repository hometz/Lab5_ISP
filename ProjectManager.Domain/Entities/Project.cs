using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Domain.Entities
{
    public class Project
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
        public string Photo { get; set; }

        public Project(string name, List<Task> tasks, string photo)
        {
            Name = name;
            Tasks = tasks;
            Photo = photo;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void AttachPhoto(string photoPath)
        {
            Photo = photoPath;
        }
    }
}
