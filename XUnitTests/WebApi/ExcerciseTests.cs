using Core;
using ExcerciseApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace XUnitTests.WebApi
{
    public class ExcerciseTests
    {
        private ExcerciseController excerciseController;
        public ExcerciseTests()
        {
            excerciseController = new ExcerciseController();
        }

        [Fact]
        public void CreateExcercise_returnsOKAndExcercise()
        {
            excerciseController.Post(new Excercise { Name = "deadlift", Id = 1 });
        }
    }
}
