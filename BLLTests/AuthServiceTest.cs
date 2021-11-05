using System;
using System.Collections.Generic;
using System.Linq;

using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DTO;
using Moq;
using NUnit.Framework;
namespace BLLTests
{
    internal class AuthServiceTest
    {
        private ServiceAuth _serviceAuth;
        private Mock<IUserRepository> _userRepo;

        [SetUp]
        public void Setup()
        {
            _userRepo = new Mock<IUserRepository>();
            _serviceAuth = new ServiceAuth(_userRepo.Object);
        }

        [Test]
        public void Login_ReturnList_AreEqual()
        {
            //Arrange
            UserDTO user_in = new UserDTO
            {
                Id=1000,
                Login="stas120900",
                Password= "4.Yj+lrO6FWb6WDTG7je2RPw==.peBYcNMPsK78IhjWPkCtiNZO9Q5BIFBdszFJgoYbyhY=",
                RoleId=1,
            };
            List<int> expected_list = new List<int>() {1,1};
            string entered_login = "stas120900";
            string entered_password = "123";
            _userRepo.Setup(u=>u.LoginData(entered_login))
                        .Returns(user_in);
            //Act
            List<int> res = _serviceAuth.LogIn(entered_login, entered_password);
            //Assert
            Assert.AreEqual(expected_list, res);
        }
    }
}
