using Microsoft.EntityFrameworkCore;

namespace testMVC.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext():base()
        {
            
        }
        public ITIContext(DbContextOptions<ITIContext> options) : base(options)
        {

        }
        //1. on configuring to open connection to DB sql server
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
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
