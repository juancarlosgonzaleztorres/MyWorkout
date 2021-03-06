﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace MyWorkout.BusinessLogic.Tests
{
    [TestClass]
    public class WorkoutTest
    {
        Workout workout = new Workout();
        Set set = new Set();
        WorkoutHistory workoutHistory;
        public WorkoutTest()
        {
            set.Excercise.Name = "deadlift";
            set.Repetitions = 5;
            set.Weight = 255;
            set.StartTime = DateTime.Now;
            set.FinishTime = set.StartTime.AddMinutes(1);
            workoutHistory = new WorkoutHistory();
            workout = workoutHistory.StartNewWorkout();
        }

        [TestMethod]
        public void StartWorkout_CreatesWorkout()
        {
            
            Assert.AreEqual(DateTime.Today, workout.StartDate);
        }

        [TestMethod]
        public void GetListOfWorkout_GetsListOfWorkouts()
        {
            Assert.IsTrue(workoutHistory.Workouts.Count == 1);
        }
    }
}
