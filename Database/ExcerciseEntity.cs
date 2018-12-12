using System;
using Core;
using Generic;

namespace Database
{
    public class ExcerciseEntity:ICRUD<Core.Excercise>
    {
        MyWorkoutContext db;
        public ExcerciseEntity()
        {
            db = new MyWorkoutContext();
        }
        public int Create(Excercise excercise)
        {
            var entity = new Exercise { Name = excercise.Name };           
            db.Exercises.Add(entity);
            db.SaveChanges();
            return entity.Id;
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