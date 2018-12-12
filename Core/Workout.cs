using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class Workout
    {
        
        public Workout()
        {
            sets = new List<Set>();
        }

        public int Id { get; set; }
        public List<Set> sets { get; set; }
    }
}
