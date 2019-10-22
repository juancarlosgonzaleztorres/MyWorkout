using System;
using Core;
using Generic;

namespace Repository
{
    public class ExcerciseRepository:ICRUD<Core.Excercise>
    {
        public ExcerciseRepository()
        {
        }

        public int Create(Excercise excercise)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Excercise Read(int id)
        {
            return new Excercise { Id=1, Name="deadlift" };
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}