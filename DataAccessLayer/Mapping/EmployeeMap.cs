using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            Property(e => e.ID)
                .IsRequired();

            Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);


            Property(e => e.LastName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(e => e.Password)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(e => e.EMail)
                .IsRequired()
                .HasColumnType("varchar");



            Ignore(e => e.FullName);



            HasRequired(e => e.Position)
                .WithMany()
                .HasForeignKey(e => e.PositionID);


        }

    }
}
