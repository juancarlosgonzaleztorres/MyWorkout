using Core;
using Generic;
using System;

namespace Database
{
    public class SetEntity:ICRUD<Core.Set>
    {
        MyWorkoutContext db;
        public SetEntity()
        {
            db = new MyWorkoutContext();
        }

        public int Create(Core.Set set)
        {            
            Set entity = new Set {
                Workout = new Workout { Id = set.Workout.Id },
                StartTime = DateTime.Now,
                FinishTime = DateTime.Now, Repetitions = "12", Weight="100",
                Exercise = new Exercise { Id = set.Excercise.Id, Name = "Dumbell" }
            };
            db.Sets.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }

        public Core.Set Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}