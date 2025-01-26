using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TryEFCodeFirstCont.Models;
namespace TryEFCodeFirstCont.EntityConfig
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //fluent API
            builder.HasKey(ww=>ww.StdID);
            builder.Property(ww => ww.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();
            builder.Property(ww => ww.DateOfBirth)
                .HasColumnType("date");
            builder.Property(ww => ww.Email)
                .HasMaxLength(50);


        }
    }
}
