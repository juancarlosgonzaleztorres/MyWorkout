using System;
using Core;
using DotNetCoreRepository2;
using Generic;

namespace Repository
{
    public class InMemoryExcerciseRepository : ICRUD<Excercise>
    {
        private ExcerciseContext _context;
        public InMemoryExcerciseRepository()
        {
            //var options = new DbContextOptionsBuilder<ExcerciseContext>()
            //    .UseInMemoryDatabase(databaseName: "ExcerciseList")
            //    .Options;
            //_context = new ExcerciseContext(options);
        }

        public int Create(Excercise excercise)
        {
            return 1;
            //_context.Add(excercise);
            //return _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Excercise Read(int id)
        {
            //return _context.ExcerciseList.Find(id);
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}