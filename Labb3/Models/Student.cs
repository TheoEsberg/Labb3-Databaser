using System;
using System.Collections.Generic;

namespace Labb3.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
        }

        public int StudentId { get; set; }
        public string SocialSecurityNumber { get; set; } = null!;
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string ClassName { get; set; } = null!;

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
