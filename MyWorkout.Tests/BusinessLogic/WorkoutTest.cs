using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace MyWorkout.BusinessLogic.Tests
{
    [TestClass]
    public class WorkoutTest
    {
        Workout workout = new Workout();
        Set set = new Set();
        WorkoutList workouts;
        public WorkoutTest()
        {
            set.Excercise.Name = "deadlift";
            set.Repetitions = 5;
            set.Weight = 255;
            set.StartTime = DateTime.Now;
            set.FinishTime = set.StartTime.AddMinutes(1);
            workouts = new WorkoutList();
        }

        [TestMethod]
        public void StartWorkout_CreatesWorkout()
        {
            Workout workout = workouts.Start();
            Assert.AreEqual(DateTime.Today, workout.StartDate);
        }
    }
}
