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
    public class Students
    {
        public static Student eenStudent = new Student
        {
            FirstName = "Arthur",
            LastName = "Morgan",
            DateOfBirth = new DateTime(1864, 6, 18)
        };
        public static Student tweeStudent = new Student
        {
            FirstName = "Mari",
            LastName = "von Sprundel",
            DateOfBirth = new DateTime(2003, 9, 6)
        };
        public static Student drieStudent = new Student
        {
            FirstName = "John",
            LastName = "Xina",
            DateOfBirth = new DateTime(2003, 9, 6)
        };
    }
}
