using System.Collections.Generic;

namespace Core
{
    public interface IWorkoutHistory
    {
        List<Workout> Workouts { get; set; }

        Workout StartNewWorkout();
    }
}