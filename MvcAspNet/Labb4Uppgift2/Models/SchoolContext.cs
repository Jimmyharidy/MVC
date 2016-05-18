using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Labb4Uppgift2.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }

        public SchoolContext() : base("SchoolDB")
        {
            Database.SetInitializer(new SchoolInitializer());
        }
    }

    public class SchoolInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student()
                {
                    StudentId = 1,
                    LastName = "Hansson",
                    Name = "Per",
                    Personnumber = "1980-12-11-7658",
                    Address = "Vindögatan 12 C",
                    Grades = new List<Grade>()
                    {
                        new Grade() {GradeId = 1, CourseName = "HTML5", GradeValue = "A"},
                        new Grade() {GradeId = 2, CourseName = "ASP.Net", GradeValue = "B"},
                        new Grade() {GradeId = 3, CourseName = "Sharepoint", GradeValue = "B"}
                    }
                },
                 new Student()
                {
                    StudentId = 2,
                    LastName = "Karlsson",
                    Name = "Jimmy",
                    Personnumber = "1984-04-28-3526",
                    Address = "Fågelgatan 16 B",
                    Grades = new List<Grade>()
                    {
                        new Grade() {GradeId = 4, CourseName = "ASP.Net Mvc", GradeValue = "B"},
                        new Grade() {GradeId = 5, CourseName = "Javascript", GradeValue = "A"},
                        new Grade() {GradeId = 6, CourseName = "C#", GradeValue = "C"}
                    }
                }
            };
            foreach (var student in students)
            {
                context.Students.Add(student);
            }
            context.SaveChanges();
        }
    }
}