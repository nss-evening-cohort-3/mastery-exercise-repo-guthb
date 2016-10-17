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
            List<string> my_first_name_list = new List<string>(new string[] { "bert", "ernie", "gordon", "bob", "ocsar", "maria", "susan", "grover", "snuffy", "kermit" });
            NameGenerator my_first_name_generator = new NameGenerator();
            Random my_new_random = new Random();

            //Act
            


            //Assert


        }

        [TestMethod]
        public void EnsureICanReturnARandomLastName()
        {
            //Arange
            List<string> my_last_name_list = new List<string>(new string[] { "red", "yellow", "blue", "green", "black", "pink", "white", "purple", "orange", "plaid" });
            NameGenerator my_last_name_generator = new NameGenerator();
            Random my_new_random = new Random();

            //Act

            //Assert

        }

        [TestMethod]
        public void EnsureICanReturnARandomMajor()
        {
            //Arange
            List<string> my_major_list = new List<string>(new string[] {"EE", "ME", "CE", "CS", "MIS", "Ed", "PSI", "PolSc" ,"ACC","MKT" });
            NameGenerator my_major_generator = new NameGenerator();
            Random my_new_random = new Random();

            //Act

            //Assert
        }

        [TestMethod]
        public void EnsureICanReturnAStudentAsString()
        {
            //Arrange
            NameGenerator my_student_generator = new NameGenerator();
            
            //Act
            
            
            
            //Assert

        }




    }
}
