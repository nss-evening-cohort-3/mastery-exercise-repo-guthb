using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RepoQuiz.DAL;
using RepoQuiz.Models;




namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceOfNameGenerator()
        {
            //Arrange

            //Act
            NameGenerator my_nameGenerator = new NameGenerator();

            //Assert
            Assert.IsNotNull(my_nameGenerator);

        }

        [TestMethod]
        public void EnsureICanReturnARandomFirstName()
        {
            //Arrange
            List<string> my_first_name_list = new List<string> { "bert", "ernie", "gordon", "bob", "ocsar", "maria", "susan", "grover", "snuffy", "kermit" };

            //Act
            NameGenerator my_first_name_generator = new NameGenerator();
            
           
            //Assert


        }

        [TestMethod]
        public void EnsureICanReturnARandomLastName()
        {
            //Arange

            //Act

            //Assert

        }

        [TestMethod]
        public void EnsureICanReturnARandomMajor()
        {
            //Arange

            //Act

            //Assert
        }




    }
}
