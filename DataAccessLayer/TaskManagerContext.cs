using _01_Entities;
using DataAccessLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class TaskManagerContext : DbContext
    {
        public TaskManagerContext()
            : base("TaskManager")
        {

        }

        internal DbSet<Customer> Customer { get; set; }
        internal DbSet<Employee> Employee { get; set; }
        internal DbSet<Position> Position { get; set; }
        internal DbSet<Project> Project { get; set; }
        internal DbSet<ProjectEmployee> ProjectEmployee { get; set; }
        internal DbSet<Request> Request { get; set; }
        internal DbSet<RequestType> RequestType { get; set; }
        internal DbSet<Work> Work { get; set; }
        internal DbSet<WorkStatus> WorkStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProjectEmployeeMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new WorkMap());


            base.OnModelCreating(modelBuilder);

        }


    }
}
