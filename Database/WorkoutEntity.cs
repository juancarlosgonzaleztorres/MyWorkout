using Core;
using Generic;

namespace Database
{
    public class WorkoutEntity:ICRUD<Core.Workout>
    {
        MyWorkoutContext db;
        public WorkoutEntity()
        {
            db = new MyWorkoutContext();
        }
        public int Create(Core.Workout workout)
        {
            Workout entity = new Workout();
            var newWorkout = db.Workouts.Add(entity);
            db.SaveChanges();
            return newWorkout.Id;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Core.Workout Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
