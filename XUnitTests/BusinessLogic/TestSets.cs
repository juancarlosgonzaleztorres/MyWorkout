using Core;
using System;
using Xunit;

namespace MyWorkout.BusinessLogic.Tests
{
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
        [Fact]
        public void AddingSet_GetsSameSet()
        {
            workout.Sets.Add(set);
            Assert.Equal("deadlift", workout.Sets[0].Excercise.Name);            
        }

        //TODO Edit a set
        [Fact]
        public void EditSet_GetsEditedSet()
        {
            workout.Sets.Add(set);
            workout.Sets[0].Excercise.Name = "Squats";
            Assert.Equal("Squats", workout.Sets[0].Excercise.Name);
        }

        [Fact]
        public void DeleteSet_DoesntFindSet()
        {
            workout.Sets.Add(set);
            workout.Sets.RemoveAt(0);
            Assert.Equal(0, workout.Sets.Count);
        }
    }
}
