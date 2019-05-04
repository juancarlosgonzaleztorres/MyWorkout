using System;
using Core;
using Generic;
using Database;

namespace Repository
{
    public class ExcerciseRepository:ICRUD<Core.Excercise>
    {
        ExcerciseEntity excerciseEntity;
        public ExcerciseRepository()
        {
            excerciseEntity = new ExcerciseEntity();
        }

        public int Create(Excercise excercise)
        {
            return excerciseEntity.Create(excercise);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Excercise Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}