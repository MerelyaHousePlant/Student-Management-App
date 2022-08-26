using System;
using System.Collections.Generic;

namespace User_Admin_Interface_take2.Models.db
{
    public partial class StudentCourse
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public int? Grade { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Students Student { get; set; }
    }
}
