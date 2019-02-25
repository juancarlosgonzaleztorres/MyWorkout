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
            Sets = new List<Set>();
        }

        public int Id { get; set; }
        public List<Set> Sets { get; set; }
    }
}