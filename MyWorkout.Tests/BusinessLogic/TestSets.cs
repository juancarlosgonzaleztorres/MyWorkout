using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace MyWorkout.BusinessLogic.Tests
{
    [TestClass]
    public class SetsTest
    {
        Workout workout = new Workout();
        Set set = new Set();
        public SetsTest()
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
        public void TestAddSet_GetSameSet()
        {
            workout.Sets.Add(set);
            Assert.AreEqual("deadlift", workout.Sets[0].Excercise.Name);
        }

        //TODO Edit a set
        [TestMethod]
        public void TestEditSet_GetsEditedSet()
        {
            workout.Sets.Add(set);
            workout.Sets[0].Excercise.Name = "Squats";
            Assert.AreEqual("Squats", workout.Sets[0].Excercise.Name);
        }

        [TestMethod]
        public void TestDeleteSet_DoesntFindSet()
        {
            workout.Sets.Add(set);
            workout.Sets.RemoveAt(0);
            Assert.AreEqual(0, workout.Sets.Count);
        }
    }
}
