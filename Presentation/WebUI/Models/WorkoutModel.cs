using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    //TODO Rename workout to WorkoutModel
    public class WorkoutModel
    {
        public int Id { get; set; }
        public Excercise excercise { get; set; }
        public int reps { get; set; }
        public int weight { get; set; }
        public DateTime finishTime  { get; set; }
        public DateTime startTime { get; set; }
    }
}