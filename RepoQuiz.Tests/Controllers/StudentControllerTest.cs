using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.Controllers;
using System.Web.Mvc;

namespace RepoQuiz.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {

        [TestMethod]
       public void CanMakeInstanceOfCohortController()
         {
            //Arrange

            //Act
            StudentController controller = new StudentController();
            
            //Assert
            Assert.IsNotNull(controller);
         }
        

        [TestMethod]
            public void Index()
            { 
                // Arrange
                StudentController controller = new StudentController();

                // Act
                ViewResult result = controller.Index() as ViewResult;

                // Assert
                Assert.IsNotNull(result);
            }


    }
    
}
