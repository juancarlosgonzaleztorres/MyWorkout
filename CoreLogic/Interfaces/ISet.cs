﻿using System;

namespace Core
{
    public interface ISet
    {
        Excercise Excercise { get; set; }
        DateTime FinishTime { get; set; }
        int Id { get; set; }
        int Repetitions { get; set; }
        DateTime StartTime { get; set; }
        int Weight { get; set; }
    }
}