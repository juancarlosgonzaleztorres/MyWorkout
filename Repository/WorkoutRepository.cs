using Database;
using Generic;
using System;

namespace Repository
{
    public class WorkoutRepository:ICRUD<Core.Workout>
    {
        WorkoutEntity workoutEntity;
        public WorkoutRepository()
        {
            workoutEntity = new WorkoutEntity();
        }

        public int Create(Core.Workout workout)
        {
            return workoutEntity.Create(workout);            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Core.Workout Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
