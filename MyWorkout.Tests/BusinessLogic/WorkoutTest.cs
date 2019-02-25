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
        public WorkoutTest()
        {
            set.Excercise.Name = "deadlift";
            set.Repetitions = 5;
            set.Weight = 255;
            set.StartTime = DateTime.Now;
            set.FinishTime = set.StartTime.AddMinutes(1);
        }
        //Confirm that an excercise is added to a 
        //workout in the logic.
        [TestMethod]
        public void TestAddExerciseToWorkout()
        {
            workout.Sets.Add(set);
            Assert.AreEqual("deadlift", workout.Sets[0].Excercise.Name);
        }

        //TODO Edit a set
        [TestMethod]
        public void TestEditSet()
        {
            workout.Sets.Add(set);
            workout.Sets[0].Excercise.Name = "Squats";
            Assert.AreEqual("Squats", workout.Sets[0].Excercise.Name);
        }

        //Get the total weight lifted (volume?) of the workout
    }
}
