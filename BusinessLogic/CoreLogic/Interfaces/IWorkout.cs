using System;
using System.Collections.Generic;

namespace Core
{
    public interface IWorkout
    {
        int Id { get; set; }
        List<ISet> Sets { get; set; }
        DateTime StartDate { get; set; }
        int TotalWeightLifted { get; }
    }
}