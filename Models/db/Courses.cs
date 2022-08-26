using System;
using System.Collections.Generic;

namespace User_Admin_Interface_take2.Models.db
{
    public partial class Courses
    {
        public Courses()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? WeeklyHours { get; set; }
        public int? NumberOfWeeks { get; set; }
        public int? Credits { get; set; }

        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
