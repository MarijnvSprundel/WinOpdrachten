using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCoursesDAL;
using StudentCoursesDAL.DB;
using StudentCoursesDAL.Models;

namespace Prc4_EF_Wk01
{
    public class Opdracht2
    {
        public static void SaveEntitiesTest()
        {
            var courseInstance = new Course()
            {
                Name = "Gender Studies",
                Description = "This course adds zero value to your life. I hope you look forward to following this course, because you are going to waste your time. If you still haven't made up your mind, I would just like to tell you that you are about to waste your time.",
                MaxParticipants = 25,
                Students = new List<Student>
                {
                    Students.eenStudent,
                    Students.tweeStudent,
                    Students.drieStudent
                },
                StartDate = new DateTime(2021, 12, 8)
            };
            using (var dbContext = new GeneralDbContext())
            {
                dbContext.Courses.Add(courseInstance);
                dbContext.SaveChanges();
            }
        }
        public static void RetrieveEntitiesTest()
        {
            using (var dbContext = new GeneralDbContext())
            {
                var retrievedCourses = dbContext.Courses.Include(c => c.Students).ToList();
                foreach (var course in retrievedCourses)
                {
                    Console.WriteLine($"Id: {course.Id}\nNaam: {course.Name}\nBeschrijving: {course.Description}\nMaximaal aantal deelnemers: {course.MaxParticipants}\nStart datum: {course.StartDate}\n\nStudents:");
                    foreach(var student in course.Students)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName}");
                    }
                    Console.WriteLine("");
                }
                //Dit moest erin zodat de console niet met licht snelheid ervandoor ging, maar in opdracht1.cs hoefde dit niet dus ik ben echt confused op dit moment
                Console.ReadLine();
            }
        }
    }
}
