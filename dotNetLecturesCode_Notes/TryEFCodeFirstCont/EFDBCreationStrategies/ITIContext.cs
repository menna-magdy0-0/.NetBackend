using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBCreationStrategies
{
    public class ITIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configuration with localhost 
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=Draft01;User Id=MennaMagdy;Password=Menna5684@noone;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}
