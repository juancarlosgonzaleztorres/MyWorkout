using Core;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2
{
    public class ExcerciseContextInMemory:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseInMemoryDatabase(databaseName: "ExcerciseList");

        public ExcerciseContextInMemory(DbContextOptions<ExcerciseContextInMemory> options):base(options)
        {
        }

        public DbSet<Excercise> ExcerciseList { get; set; }
    }
}
