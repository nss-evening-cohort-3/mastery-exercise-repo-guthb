using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RepoQuiz.DAL;
using RepoQuiz.Models;
using RepoQuiz.Migrations;




namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        
        [TestMethod]
        public void EnsureICanReturnAStudentAsString()
        {
            //Arrange
            NameGenerator my_student_generator = new NameGenerator();

            //Act
            object my_string = my_student_generator.randomFirstName();

            //Assert
            Assert.IsInstanceOfType(my_string, typeof (string) );
        }

    }
}
