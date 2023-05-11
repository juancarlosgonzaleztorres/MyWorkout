using Core;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("MyWorkout");
            do
            {
                Console.WriteLine("Enter # option\n" +
                    "1) Enter workout\n" +
                    "2) Demo entering workout\n" +
                    "3) Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        demoWorkout();
                        break;
                    default:
                        break;
                }
                
            } while (choice !=3 );
        }

        public static void demoWorkout()
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

            Console.WriteLine("total weight lifted in workout: {0} lbs", workout.TotalWeightLifted);
            Console.ReadLine();
        }
    }
}
