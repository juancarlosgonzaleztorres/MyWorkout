using DotNetCoreRepository2.Models;
using Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreRepository2.Excercise
{
    public class EFExcerciseRepository : ICRUD<Core.Excercise>
    {
        MyWorkoutContext _dbContext;
        public EFExcerciseRepository()
        {
            _dbContext = new MyWorkoutContext();
        }
        public EFExcerciseRepository(MyWorkoutContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(Core.Excercise item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Core.Excercise Read(int id)
        {
    //        var contextOptions = new DbContextOptionsBuilder<MyWorkoutContext>()
    //.UseSqlServer(@"Data Source=corsair;Initial Catalog=MyWorkout;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True")
    ////.UseSqlServer(@"Server=corsair;Database=MyWorkout")
    //.Options;
    //        var context = new MyWorkoutContext();
            var result = _dbContext.Excercises.Where(x=> x.Id == id);
            var excerciseNmae = result.FirstOrDefault().Name;
            throw new NotImplementedException();
        }

        public List<Core.Excercise> Read()
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Excercise item)
        {
            throw new NotImplementedException();
        }
    }
}
