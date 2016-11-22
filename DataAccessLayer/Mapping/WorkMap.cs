using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class WorkMap : EntityTypeConfiguration<Work>
    {
        public WorkMap()
        {
            HasKey(w => w.ID);

            HasRequired(w => w.Project)
                .WithMany()
                .HasForeignKey(w => w.ProjectID)
                .WillCascadeOnDelete(false);

            Property(w => w.StartDate)
                .HasColumnType("date")
                .IsOptional();

            Property(w => w.EndDate)
                .HasColumnType("date")
                .IsOptional();
            Property(w => w.CreationDate)
                .HasColumnType("date")
                .IsRequired();
            HasRequired(w => w.Manager)
               .WithMany()
               .HasForeignKey(w => w.ManagerID)
               .WillCascadeOnDelete(false);

            HasOptional(w => w.Employee)
                .WithMany()
                .HasForeignKey(w => w.EmployeeID);

            Property(w => w.WorkDetail)
                .HasColumnType("varchar")
                .IsRequired();

            HasRequired(w => w.WorkStatus)
               .WithMany()
               .HasForeignKey(w => w.WorkStatusID);



        }
    }
}
