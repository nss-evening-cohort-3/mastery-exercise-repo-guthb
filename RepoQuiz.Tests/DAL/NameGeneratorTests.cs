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

            //Students property returns fake database table
            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);

            //define callback for response to a called method
            mock_student_table.Setup(t => t.Add(It.IsAny<Student>())).Callback((Student s) => student_list.Add(s));
            mock_student_table.Setup(t => t.Remove(It.IsAny<Student>())).Callback((Student s) => student_list.Remove(s));

        }


    }
}
