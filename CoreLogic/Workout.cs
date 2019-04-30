using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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