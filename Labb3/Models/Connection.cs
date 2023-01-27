using System;
using System.Collections.Generic;

namespace Labb3.Models
{
    public partial class Connection
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
