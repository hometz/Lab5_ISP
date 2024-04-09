using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManager.Domain.Entities;

namespace ProjectManager.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        IRepository<Project> ProjectRepsitory { get; };

        void Save();
    }
}
