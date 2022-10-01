using Microsoft.EntityFrameworkCore;
using ToDoListWeb.Models;

namespace ToDoListWeb
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Assignment>()
                .Property(x => x.Text).IsRequired();

            modelBuilder.Entity<Assignment>()
                .Property(x => x.Name).IsRequired();
        }
    }
}
