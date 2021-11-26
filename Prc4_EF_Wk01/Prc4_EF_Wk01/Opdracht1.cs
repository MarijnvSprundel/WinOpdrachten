using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentCoursesDAL;
using StudentCoursesDAL.DB;
using StudentCoursesDAL.Models;

namespace Prc4_EF_Wk01
{
    public class Opdracht1
    {
        public static void SaveEntitiesTest()
        {
            var eenStudent = new Student
            {
                FirstName = "Arthur",
                LastName = "Morgan",
                DateOfBirth = new DateTime(1864, 6, 18)
            };
            var tweeStudent = new Student
            {
                FirstName = "Mari",
                LastName = "von Sprundel",
                DateOfBirth = new DateTime(2003, 9, 6)
            };
            var drieStudent = new Student
            {
                FirstName = "John",
                LastName = "Xina",
                DateOfBirth = new DateTime(1989, 6, 4)
            };
            using (var dbContext = new StudentDbContext())
            {
                dbContext.Students.Add(eenStudent);
                dbContext.Students.Add(tweeStudent);
                dbContext.Students.Add(drieStudent);
                dbContext.SaveChanges();
            }
        }
        public static void RetrieveEntitiesTest()
        {
            using (var dbContext = new StudentDbContext())
            {
                var retrievedStudents = dbContext.Students;
                foreach(var student in retrievedStudents)
                {
                    Console.WriteLine($"Id: {student.Id}\nNaam: {student.FirstName} {student.LastName}\nGeboortedatum: {student.DateOfBirth}\n\n");
                }
            }
        }
    }
}
