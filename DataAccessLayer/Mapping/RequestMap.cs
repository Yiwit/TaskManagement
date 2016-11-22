using _01_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    class RequestMap : EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            HasKey(r => r.ID);

            Property(r => r.RequestDetail)
                .IsRequired()
                .HasColumnType("varchar");

            HasRequired(r => r.Project)
                .WithMany()
                .HasForeignKey(r => r.ProjectID)
                .WillCascadeOnDelete(false);

            HasRequired(r => r.Employee)
                .WithMany()
                .HasForeignKey(r => r.EmployeeID);

            HasRequired(r => r.RequestType)
                .WithMany()
                .HasForeignKey(r => r.RequestTypeID);

            Property(r => r.State)
                .HasColumnAnnotation("DefaultValue", true);
                
        }
    }
}
