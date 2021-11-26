using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCoursesDAL.Models
{
    [Table("Students")]public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(250)]
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
    }
}
