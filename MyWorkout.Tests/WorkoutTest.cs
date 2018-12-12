using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace WebUI.Tests
{
    [TestClass]
    public class WorkoutTest
    {
        //Confirm that an excersice is added to a workout.
        [TestMethod]
        public void TestAddExerciseToWorkout()
        {
            Workout workout = new Workout();
            Set set = new Set();            
            set.Excercise.Name = "deadlift";
            set.Repetitions = 5;
            set.Weight = 255;
            set.StartTime = DateTime.Now;
            set.FinishTime = DateTime.Now;
            workout.sets.Add(set);
            Assert.AreEqual("deadlift", workout.sets[0].Excercise.Name);
        }

        //Get the total weight lifted (volume?) of the workout
    }
}
