using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.ID);


            Property(c => c.CompanyName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.ContactName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);


        }
    }
}
