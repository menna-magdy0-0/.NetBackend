using EFCoreFirstLook.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFirstLook.Entities
{
    //Ef runtime
    public class CompanyContext : DbContext
    {
        //configure EF Runtime to connect to specific Database 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=EFCoreFirstLook;User Id=MennaMagdy;Password=Menna5684@noone;TrustServerCertificate=True;");
        }
        //fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Name).IsRequired();
            //    entity.Property(e => e.Salary).IsRequired();
            //    entity.Property(e => e.Age).IsRequired(false);
            //});
            base.OnModelCreating(modelBuilder);
        }

        //Build Containers for classes that will be Entity in Database
        ////DataTable Ado.Net
        /////DbSet Entity Framework



        /////virtual => lazy loading=> default in EF core 
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
