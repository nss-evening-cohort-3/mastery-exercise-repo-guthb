using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RepoQuiz.DAL;
using RepoQuiz.Models;
using Moq;
using System.Data.Entity;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {

        //creating mock studentsontext
        Mock<StudentContext> mock_context { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        List<Student> student_list { get; set; }
        StudentRepository repo { get; set; }

        //creating mock connections
        public void ConnectMocksToDataStore()
        {
            var queryable_list = student_list.AsQueryable();

            //tricking LINQ to to think list is a database table
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            //students property returns fake database table
            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);

            //define callback for response to a called method
            mock_student_table.Setup(t => t.Add(It.IsAny<Student>())).Callback((Student s) => student_list.Add(s));
            

        }

        [TestInitialize] //runs before any tests
        public void Intialize()
        {
            //create
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            student_list = new List<Student>();  //fake database
            repo = new StudentRepository(mock_context.Object);

            ConnectMocksToDataStore();

        }

        [TestCleanup] //runs after every test
        public void TearDown()
        {
            repo = null; //reset repo 
        }


        [TestMethod]
        public void RepoEnsureCanCreateInstance()
        {
            StudentRepository repo = new StudentRepository();
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void RepoEnsureRepoHasContext()
        {
            StudentRepository repo = new StudentRepository();
            StudentContext actual_context = repo.Context;

            Assert.IsInstanceOfType(actual_context, typeof(StudentContext));
        }

        [TestMethod]
        public void RepoEnsureWeHaveNoStudents()
        {
            //Arrange
            
            //Act
            List<Student> some_students = repo.GetStudents();
            int expected_student_count = 0;
            int actual_student_count = some_students.Count;

            //Assert
            Assert.AreEqual(expected_student_count, actual_student_count);

        }


    }
}
