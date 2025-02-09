using Microsoft.EntityFrameworkCore;

namespace testMVC.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext():base()
        {
            
        }
        //1. on configuring to open connection to DB sql server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=Day2MVC;User Id=MennaMagdy;Password=Menna5684@noone;TrustServerCertificate=True;");
        }
        //2. on model creating to add properties to entities if you need
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //3. create entities of models 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
