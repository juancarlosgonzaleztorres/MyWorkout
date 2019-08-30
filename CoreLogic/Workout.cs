using System;
using System.Collections.Generic;

namespace Core
{
    public class Workout
    {
        public int TotalWeightLifted
        {
            get
            {
                int totalWeight = 0;
                foreach (var s in Sets)
                {
                    totalWeight += s.Weight * s.Repetitions;
                }
                return totalWeight;
            }
        }

        public DateTime StartDate { get; set; }
        public int Id { get; set; }
        public List<Set> Sets { get; set; }
        public Workout()
        {
            Sets = new List<Set>();
        }        
    }
}