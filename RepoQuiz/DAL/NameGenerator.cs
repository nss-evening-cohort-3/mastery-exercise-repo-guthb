using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)

        private List<string> firstNameList = new List<string>(new string [] {"a", "b", "c", "d", "e", "f",
        "g", "h", "i", "j"});

        private List<string> majorList = new List<string>(new string[]{ "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

        private List<string> lastNameList = new List<string>(new string[]{"Smith", "Tabby", "Black", "Fish", "Brown", "Young",
        "Winkle", "Capcha", "Ohmaha", "Turk"});

        Random randomGenerator = new Random();

        public NameGenerator() {
            //var test = lastNameList[randomGenerator.Next(lastNameList.Count)];
        }

        public string randomFirstName()
        {
            return firstNameList[randomGenerator.Next(firstNameList.Count)];

        }

        public string randomLastName()
        {
            return firstNameList[randomGenerator.Next(lastNameList.Count)];
        }

        public string randomMajor()
        {
            return majorList[randomGenerator.Next(majorList.Count)];
        }

        

    }
}