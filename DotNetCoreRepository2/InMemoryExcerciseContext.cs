using Core;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2
{
    public class InMemoryExcerciseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseInMemoryDatabase(databaseName: "ExcerciseList");

        public InMemoryExcerciseContext(DbContextOptions<InMemoryExcerciseContext> options):base(options)
        {
        }

        public DbSet<Excercise> ExcerciseList { get; set; }
    }
}
