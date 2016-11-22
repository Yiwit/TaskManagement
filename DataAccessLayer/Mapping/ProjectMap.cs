using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            HasKey(p => p.ID);

            Property(p => p.ProjectName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.ProjectDetail)
                .IsRequired()
                .HasColumnType("varchar");

            HasRequired(p => p.Manager)
                .WithMany()
                .HasForeignKey(p => p.ManagerID);

            HasRequired(p => p.Customer)
                .WithMany()
                .HasForeignKey(p => p.CustomerID);

            Property(x => x.PlannedEndDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(p => p.PlannedStartDate)
                .IsRequired()
                .HasColumnType("datetime");

            Property(p => p.StartDate)
                .IsOptional()
                .HasColumnType("datetime");

            Property(p => p.EndDate)
                .IsOptional()
                .HasColumnType("datetime");


        }
    }
}
