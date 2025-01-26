using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryEFCodeFirstCont.EntityConfig;
using TryEFCodeFirstCont.Models;

namespace TryEFCodeFirstCont.Context
{
    //EF Runtime 
    public class CompanyContext:DbContext
    {
        //
        public CompanyContext():base()
        {

        }
        public CompanyContext(DbContextOptions options):base(options)
        {
            
        }
        //
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=TryEFCodeFirstCont;User Id=MennaMagdy;Password=Menna5684@noone;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Server=.;Database=CompanyDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //fluent API
            #region Old Technique
            ////course Model  legacy EF + EF6 core
            //modelBuilder.Entity<Course>().HasKey(c => c.Crs_Id);//third method of creating primary key in ef core
            //modelBuilder.Entity<Course>().Ignore(c => c.RegisterTime);
            ////modelBuilder.Entity<Course>().Ignore(c=>c.RegisterTime).HasKey(c => c.Crs_Id);//third method of creating primary key in ef core using chaining and must be ignore before haskey 
            //modelBuilder
            //    .Entity<Course>()
            //    .Property(c => c.Name)
            //    .HasMaxLength(50)
            //    .IsRequired()
            //    .IsUnicode();

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.Course_Desc)
            //    .HasColumnName("crs_desc")
            //    .HasMaxLength(50)
            //    .IsUnicode(); 
            #endregion

            //New Technique
            modelBuilder.Entity<Course>(crsConfig =>
            {
                crsConfig
                .Ignore(e=>e.RegisterTime)
                .HasKey(e => e.Crs_Id);
                crsConfig
                    .Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode()
                    .IsRequired();
                crsConfig
                    .Property(e => e.Course_Desc)
                    .HasColumnName("crs_desc")
                    .HasMaxLength(50)
                    .IsUnicode();
            });
            //Apply External Configuration in model creation
            modelBuilder.ApplyConfiguration(new StudentConfig());
            base.OnModelCreating(modelBuilder);
        }
        //
        public override int SaveChanges()
        {
            ////add functionality 
            ///overhead
            //var entities = from e in ChangeTracker.Entries()
            //               where e.State==EntityState.Added
            //               || e.State==EntityState.Modified
            //               select e.Entity;
            //foreach (var entity in entities)
            //{
            //    var validationContext = new ValidationContext(entity);
            //    Validator.ValidateObject(entity, validationContext);
            //}
            //keep behavior 
            return base.SaveChanges();
        }
        //
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
    }
}
