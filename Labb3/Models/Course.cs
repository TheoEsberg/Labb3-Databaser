using System;
using System.Collections.Generic;

namespace Labb3.Models
{
    public partial class Course
    {
        public Course()
        {
            Grades = new HashSet<Grade>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int TeacherId { get; set; }

        public virtual Employee Teacher { get; set; } = null!;
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
