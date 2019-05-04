using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MockUpSetListRepository
    {
        public List<Set> GetSetsByWorkoutId(int id)
        {
            List<Set> sets = new List<Set>
            {
             new Set
                {
                    Excercise =new Excercise { Name="Deadlift", Id=1 },
                    Repetitions=12,
                    StartTime=new DateTime(2016,02,14,20,16,15),
                    Weight=315                    
                },
             new Set
                {
                    Excercise =new Excercise { Name="Deadlift", Id=1 },
                    Repetitions=12,
                    StartTime=new DateTime(2016,02,14,20,16,15),
                    Weight=315
                },
             new Set
                {
                    Excercise =new Excercise { Name="Deadlift", Id=1 },
                    Repetitions=12,
                    StartTime=new DateTime(2016,02,14,20,16,15),
                    Weight=315
                },
             new Set
                {
                    Excercise =new Excercise { Name="Deadlift", Id=1 },
                    Repetitions=12,
                    StartTime=new DateTime(2016,02,14,20,16,15),
                    Weight=315
                },
             new Set
             {
                 Excercise =new Excercise {Name="Squat",Id=2 },
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight = 255
             },
             new Set
             {
                 Excercise =new Excercise {Name="Squat",Id=2 },
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight = 255
             },
             new Set
             {
                 Excercise =new Excercise {Name="Squat",Id=2 },
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight = 255
             },
             new Set
             {
                 Excercise =new Excercise {Name="Squat",Id=2 },
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight = 255
             },
             new Set
             {
                 Excercise =new Excercise {Name="Squat",Id=2 },
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight = 255
             },
             new Set
             {
                 Excercise=new Excercise { Name="Bench Press", Id=3},
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight=185
             },
             new Set
             {
                 Excercise=new Excercise { Name="Bench Press", Id=3},
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight=185
             },
             new Set
             {
                 Excercise=new Excercise { Name="Bench Press", Id=3},
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight=185
             },
             new Set
             {
                 Excercise=new Excercise { Name="Bench Press", Id=3},
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight=185
             },
             new Set
             {
                 Excercise=new Excercise { Name="Bench Press", Id=3},
                 Repetitions=12,
                 StartTime=new DateTime(2016,02,14,20,16,15),
                 Weight=185
             },

            };
            return sets;            
        }
    }
}
