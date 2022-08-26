using System;
using System.Collections.Generic;

namespace User_Admin_Interface_take2.Models.db
{
    public partial class Students
    {
        public Students()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentUserName { get; set; }
        public int CurrentYear { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
        public bool? IsAdmin { get; set; }
        public string StudentPassword { get; set; }

        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
