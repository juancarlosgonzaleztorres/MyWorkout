using Core;
using Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Repository
{
    public class ExcerciseRepository:ICRUD<Excercise>
    {
        DbContext context;
        public ExcerciseRepository(DbContext context)
        {
            this.context = context;
        }

        public int Create(Excercise excercise)
        {
            try
            {
                if (excercise != null && Read(excercise.Id) is null)
                {
                    context.Add(excercise);
                }
                return context.SaveChanges();
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
            return context.Find<Excercise>(id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}