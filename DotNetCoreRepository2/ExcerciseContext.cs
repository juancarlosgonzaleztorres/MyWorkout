using Core;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRepository2
{
    public class ExcerciseContext:DbContext
    {
        public ExcerciseContext(DbContextOptions<ExcerciseContext> options):base(options)
        {
        }

        public DbSet<Excercise> ExcerciseList { get; set; }
    }
}
