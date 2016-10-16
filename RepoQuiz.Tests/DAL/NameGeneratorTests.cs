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
        

    }
}
