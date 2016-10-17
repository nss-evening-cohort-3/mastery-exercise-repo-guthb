namespace RepoQuiz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RepoQuiz.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            /*if (System.Diagnostics.Debugger.IsAttached == false)
            {
                System.Diagnostics.Debugger.Launch();
            }*/

        }

        private Models.Student studentRecurse(RepoQuiz.DAL.StudentContext _context)
        {
            NameGenerator _nameGenerator = new NameGenerator();
            Models.Student recurseStudent = new Models.Student()
            {
                FirstName = _nameGenerator.randomFirstName(),
                LastName = _nameGenerator.randomLastName(),
                Major = _nameGenerator.randomMajor()
            };
            

            if ( _context.Students.FirstOrDefault(r => r.FirstName == recurseStudent.FirstName 
                 && r.LastName == recurseStudent.LastName) != null )
            {
                
                recurseStudent = studentRecurse(_context);
            }
            
            return recurseStudent;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
            for (int i = 0; i < 10; i++)
            {
                context.Students.Add(studentRecurse(context));
                context.SaveChanges();
            }
            
           
        }


    }
}
