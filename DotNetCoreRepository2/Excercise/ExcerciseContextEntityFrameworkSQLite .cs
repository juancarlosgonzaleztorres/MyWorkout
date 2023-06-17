using Core;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2.Excercise
{
    public class EntityFrameworkSQLiteExcerciseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlite("Data Source=excercises.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Excercise>()
                .ToTable("Excercise")
                .Property(b => b.Id)
                .IsRequired();
        }
        public DbSet<Excercise> Excercises { get; set; }
    }
}
