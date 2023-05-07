using Core;
using System;
using Xunit;

namespace MyWorkout.BusinessLogic.Tests
{
    public class WorkoutTest
    {
        IWorkout workout = new Workout();
        Set set = new Set();
        WorkoutHistory workoutHistory;
        public WorkoutTest()
        {
            workoutHistory = new WorkoutHistory();
            workout = workoutHistory.StartNewWorkout();
            set.Excercise.Name = "deadlift";
            set.Repetitions = 5;
            set.Weight = 255;
            set.StartTime = DateTime.Now;
            set.FinishTime = set.StartTime.AddMinutes(1);
            workout.Sets.Add(set);
        }

        [Fact]
        public void StartWorkout_CreatesWorkout()
        {
            
            Assert.Equal(DateTime.Today, workout.StartDate);
        }

        [Fact]
        public void GetListOfWorkout_GetsListOfWorkouts()
        {
            Assert.True(workoutHistory.Workouts.Count == 1);
        }

        [Fact]
        public void GetWeightLiftedInWorkout_ReturnsWeight()
        {
            Assert.True(workout.TotalWeightLifted == 5*255);
        }
    }
}
