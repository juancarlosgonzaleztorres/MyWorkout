using Core;
using ExcerciseApi.Controllers;
using Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
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
            var mockRepository = new Mock<ICRUD<Excercise>>();
            excerciseController = new ExcerciseController(mockRepository.Object);
        }

        [Fact]
        public void CreateExcercise_returnsOKAndExcercise()
        {
            Assert.Equal(StatusCodes.Status200OK.ToString(), ((StatusCodeResult)excerciseController.Post(new Excercise { Name = "deadlift", Id = 1 })).StatusCode.ToString());
        }


    }
}