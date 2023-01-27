using System;
using System.Collections.Generic;

namespace Labb3.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Courses = new HashSet<Course>();
            Grades = new HashSet<Grade>();
        }

        public int EmployeeId { get; set; }
        public string WorkTitle { get; set; } = null!;
        public string FullName { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
