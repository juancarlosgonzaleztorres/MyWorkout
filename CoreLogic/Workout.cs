using System;
using System.Collections.Generic;

namespace Core
{
    public class Workout
    {
        public DateTime StartDate { get; set; }
        public int Id { get; set; }
        public List<Set> Sets { get; set; }
        public Workout()
        {
            Sets = new List<Set>();
        }        
    }
}