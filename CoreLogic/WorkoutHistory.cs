using System;
using System.Collections.Generic;

namespace Core
{
    public class WorkoutHistory : IWorkoutHistory
    {
        private readonly IWorkoutRepository repository;
        public WorkoutHistory()
        {
            Workouts = new List<Workout>();
        }
        public List<Workout> Workouts
        { get; set; }

        public Workout StartNewWorkout()
        {
            var workout = new Workout { StartDate = DateTime.Today };
            Workouts.Add(workout);
            return workout;
        }
    }
}