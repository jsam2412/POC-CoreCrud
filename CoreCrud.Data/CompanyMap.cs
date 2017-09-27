using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreCrud.Data
{
    public class CompanyMap
    {
        public CompanyMap(EntityTypeBuilder<Company> entityBuilder)
        {

            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.CompanyName).IsRequired();
            entityBuilder.Property(t => t.Address);
            // entityBuilder.HasOne(t => t.Users).WithOne(u=>u.Id);

            //    HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
