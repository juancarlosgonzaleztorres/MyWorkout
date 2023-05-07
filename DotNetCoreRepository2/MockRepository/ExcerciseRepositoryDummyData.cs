using Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreRepository2.MockRepository
{
    public class ExcerciseRepositoryDummyData : ICRUD<Core.Excercise>
    {
        public int Create(Core.Excercise item)
        {
            return 1;
        }

        public void Delete(int id)
        {
        }

        public Core.Excercise Read(int id)
        {
            return new Core.Excercise
            {
                Name = "deadlift",
                Id = 1
            };
        }

        public List<Core.Excercise> Read()
        {
            return new List<Core.Excercise> {
            new Core.Excercise
            {
                Name = "deadlift",
                Id = 1
            },
            new Core.Excercise
            {
                Name = "Romanian deadlift",
                Id = 2
            } 
            } ;
        }

        public void Update(int id)
        {
        }

        public void Update(Core.Excercise item)
        {
        }
    }
}
