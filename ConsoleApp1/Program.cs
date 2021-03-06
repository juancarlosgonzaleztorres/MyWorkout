﻿using Core;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkoutHistory workoutList = new WorkoutHistory();
            var workout = workoutList.StartNewWorkout();

            for (int i = 0; i < 4; i++)
            {
                workout.Sets.Add(new Set { Repetitions = 10, StartTime = DateTime.Now, FinishTime = DateTime.Now.AddMinutes(1), Excercise = new Excercise { Name = "Deadlift" }, Weight = 225 });
            }

            Console.WriteLine("Automatically entered workout");

            foreach (var set in workoutList.Workouts[0].Sets)
            {                
                Console.WriteLine("Excercise:{0}, Weight:{1}, Reps:{2}", set.Excercise.Name, set.Weight, set.Repetitions);
            }

            Console.ReadLine();
        }
    }
}
