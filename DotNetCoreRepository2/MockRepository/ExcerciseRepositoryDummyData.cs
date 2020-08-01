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

        public void Update(int id)
        {
        }
    }
}
