using EFTask1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Entities
{
    public class NewsDBContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); // Enable lazy loading
            optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=NewsDB;User Id=MennaMagdy;Password=Menna5684@noone;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>(NConfig =>
            {
                NConfig.HasKey(n => n.NewsId);
                NConfig.Property(n => n.Title).HasMaxLength(50).IsRequired();
                NConfig.Property(n => n.bref).HasMaxLength(50).IsRequired();
                NConfig.Property(n => n.Description).HasMaxLength(100);


            });
            modelBuilder.Entity<Author>(AConfig =>
            {
                AConfig.HasKey(n => n.AuthorId);
                AConfig.Property(n => n.Name).HasMaxLength(50).IsRequired();
                AConfig.Property(n => n.UserName).HasMaxLength(50).IsRequired();
                AConfig.Property(n => n.Password).HasMaxLength(50).IsRequired();
                AConfig.Property(n => n.Bref).HasMaxLength(50).IsRequired();

            });

            modelBuilder.Entity<Catalog>(CConfig =>
            {
                CConfig.HasKey(n => n.CatalogId);
                CConfig.Property(n => n.Name).HasMaxLength(50).IsRequired();
                CConfig.Property(n => n.Description).HasMaxLength(50).IsRequired();

            });
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<News> News { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
    }
}
