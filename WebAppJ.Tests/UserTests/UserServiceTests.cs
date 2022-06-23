using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJ.Api.Controllers;
using WebAppJ.BL.Interfaces;
using WebAppJ.BL.Models;
using Xunit;

namespace WebAppJ.Tests.UserTests
{
    public class UserServiceTests
    {

        [Fact]
        public void GetUserTest()
        {
            // arrange
            var mockService = new Mock<IUserService>();
            var mockLogger = new Mock<ILogger<UserController>>();
            var userController = new UserController(mockService.Object, mockLogger.Object);
            // act
            var result = userController.GetUser();

            // assert
            var objectResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(200, objectResult.StatusCode);
        }

        [Fact]
        public void GetUserTest2()
        {
            // arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(x => x.GetUser()).Returns(new UserItem { Id = 10, Name = "Admin"});

            
            var mockLogger = new Mock<ILogger<UserController>>();
            var userController = new UserController(mockService.Object, mockLogger.Object);
            // act
            var result = userController.GetUser();

            // assert
            var objectResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.NotNull(objectResult.Value);
        }

        [Fact]
        public void GetUserTest3()
        {
            // arrange
            var mockService = new Mock<IUserService>();
            mockService.Setup(x => x.GetUser()).Returns(new UserItem { Id = 10, Name = "Admin" });


            var mockLogger = new Mock<ILogger<UserController>>();
            var userController = new UserController(mockService.Object, mockLogger.Object);
            // act
            var result = userController.GetUser();

            // assert
            var user = Assert.IsAssignableFrom<OkObjectResult>(result).Value as UserItem;
            Assert.Equal(10, user?.Id);
        }



    }
}
