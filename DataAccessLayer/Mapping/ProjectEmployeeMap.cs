using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ProjectEmployeeMap : EntityTypeConfiguration<ProjectEmployee>
    {
        public ProjectEmployeeMap()
        {

            HasRequired(pe => pe.Employee)
                .WithMany()
                .HasForeignKey(pe => pe.EmployeeID);

            HasRequired(pe => pe.Project)
                .WithMany()
                .HasForeignKey(pe => pe.ProjectID)
                .WillCascadeOnDelete(false);

            HasKey(pe => new { pe.ProjectID, pe.EmployeeID });
        }
    }
}
