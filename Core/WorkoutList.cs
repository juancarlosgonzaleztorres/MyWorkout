using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class WorkoutList
    {        
        private IWorkoutRepository repository;
        public WorkoutList()
        {
            Workouts = new List<Workout>();
        }
        public List<Workout> Workouts
        {   get;  set;  }

        public Workout Start()
        {
            var workout = new Workout { StartDate = DateTime.Today };
            Workouts.Add(workout);
            return workout;
        }
    }
}