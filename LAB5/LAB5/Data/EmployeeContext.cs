using LAB5.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB5.Data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext() { }
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Surname).IsRequired().HasMaxLength(50);

                entity.Property(e => e.Position).IsRequired().HasMaxLength(100);


            });
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}

