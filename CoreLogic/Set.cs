using System;

namespace Core
{
    public class Set : ISet
    {
        public Set()
        {
            Excercise = new Excercise();
        }
        public int Id { get; set; }
        public int Repetitions { get; set; }
        public Excercise Excercise { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int Weight { get; set; }
    }
}
