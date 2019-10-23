using System;
using System.Reflection;
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
            try
            {
                if (excercise!= null && Read(excercise.Id) is null)
                {
                    _context.Add(excercise);                    
                }
                return _context.SaveChanges();
            }
            catch
            {
                throw new Exception(MethodBase.GetCurrentMethod().Name);
            }
            
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