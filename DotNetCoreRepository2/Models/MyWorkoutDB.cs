//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNetCoreRepository2.Models
//{
//    public class MyWorkoutDB : MyWorkoutContext
//    {
//        public MyWorkoutDB(DbContextOptions<MyWorkoutContext> options) : base(options)
//        {

//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Data Source=corsair;Initial Catalog=MyWorkout;Integrated Security=True");
//        }
//    }
//}
