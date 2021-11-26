using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentCoursesDAL.Models
{
    [Table("Courses")] public class Course
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(250)]
        public string Description { get; set; }
        [Required, Range(0, 30)]
        public int MaxParticipants { get; set; }
        public List<Student> Students { get; set; }
        public DateTime? StartDate { get; set; }

    }
}
