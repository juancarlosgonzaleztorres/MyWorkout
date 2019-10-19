using System;
using Core;
using DotNetCoreRepository2;
using Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class InMemoryExcerciseRepository : ICRUD<Excercise>
    {
        private ExcerciseContext _context;
        public InMemoryExcerciseRepository()
        {
            var options = new DbContextOptionsBuilder<ExcerciseContext>()
                .UseInMemoryDatabase(databaseName: "ExcerciseList")
                .Options;
            _context = new ExcerciseContext(options);
        }

        public int Create(Excercise excercise)
        {
            _context.Add(excercise);
            return _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Excercise Read(int id)
        {
            return _context.ExcerciseList.Find(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}