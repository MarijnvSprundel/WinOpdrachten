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
            using (var dbContext = new GeneralDbContext())
            {
                dbContext.Students.Add(Students.eenStudent);
                dbContext.Students.Add(Students.tweeStudent);
                dbContext.Students.Add(Students.drieStudent);
                dbContext.SaveChanges();
            }
        }
        public static void RetrieveEntitiesTest()
        {
            using (var dbContext = new GeneralDbContext())
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
