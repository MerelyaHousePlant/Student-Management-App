using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Admin_Interface_take2.Models.db;

namespace User_Admin_Interface_take2.Resources
{
    public class ProfileManager
    {
        public void GetUserProfileData(ListBox profileDisplay)
        {
            profileDisplay.Items.Add(Authenticate.userProfile.StudentId);
            profileDisplay.Items.Add(Authenticate.userProfile.StudentUserName);
            profileDisplay.Items.Add(Authenticate.userProfile.StudentPassword);
            profileDisplay.Items.Add(Authenticate.userProfile.StudentPhone);
            profileDisplay.Items.Add(Authenticate.userProfile.StudentEmail);
            profileDisplay.Items.Add(Authenticate.userProfile.StudentName);
        }
    
    
       public void GetUserList(DataGridView userEntries)
        {
            var usercontext = new StudentsContext();
            var userdata = from c in usercontext.Students select c;
            if(userdata != null)
            {
                if(userdata.Count() > 0)
                {
                    userEntries.DataSource = userdata.ToList();
                }
                else
                {
                    MessageBox.Show("No entries were found");
                }
            }
        }

        public void GetCoursesList(DataGridView courseEntries)
        {
            var coursecontext = new StudentsContext();
            var coursedata = from c in coursecontext.Courses select c;
            if (coursedata != null)
            {
                if (coursedata.Count() > 0)
                {
                    courseEntries.DataSource = coursedata.ToList();
                }
                else
                {
                    MessageBox.Show("No entries were found");
                }
            }
        }
        public void DeleteCourse(int stateCourseID)
        {
            var context = new StudentsContext();
            var cursed = new Courses { CourseId = stateCourseID };
            context.Courses.Remove(cursed);
            context.SaveChanges();
        }

        public void DeleteStudent(int stateStudentID)
        {
            var context = new StudentsContext();
            var stunted = new Students { StudentId = stateStudentID };
            context.Students.Remove(stunted);
            context.SaveChanges();
        }
    
        public void EditCourse(int choosenCourseID, string editName, int editHours, int editWeeks, int editCredits)
        {
            var context = new StudentsContext();
            Courses editor = context.Courses.First(c => c.CourseId == choosenCourseID);
            editor.CourseName = editName;
            editor.WeeklyHours = editHours;
            editor.NumberOfWeeks = editWeeks;
            editor.Credits = editCredits;
            context.SaveChanges();
            MessageBox.Show("Course edited succesfully");
        }

        public void EditStudent(int choosenStudentID, string editName, string editUsername, int editYear, string editMail, string editPhone, string editPassword)
        {
            var context = new StudentsContext();
            
            Students editor = context.Students.First(c => c.StudentId == choosenStudentID);
            editor.StudentName = editName;
            editor.StudentUserName = editUsername;
            editor.CurrentYear = editYear;
            editor.StudentEmail = editMail;
            editor.StudentPhone = editPhone;
            editor.StudentPassword =editPassword;
            context.SaveChanges();
            MessageBox.Show("Profile edited succesfully");
        }

        public void SelectRow(DataGridView coursesOnDisplay,int chooseID)
        {
            //coursesOnDisplay.SelectedRows.Clear();

            foreach (DataGridViewRow row in coursesOnDisplay.Rows)
            {
                if (Int32.Parse(row.Cells[0].Value.ToString()) == chooseID)
                {
                    row.Selected = true;
                }
                if (row.Selected == true)
                {
                    var context = new StudentsContext();
                    StudentCourse Entry = new StudentCourse();
                    Entry.StudentId = Authenticate.userProfile.StudentId;
                    Entry.CourseId = Int32.Parse(row.Cells[0].Value.ToString());
                    Entry.Grade = 5;
                    context.StudentCourse.Add(Entry);
                    context.SaveChanges();
                    MessageBox.Show("Registered Succesfully");
                }
            }
        }
     public void ShowStudentCourses(int profileID, ref ListBox profileCourses)
        {
            var db = new StudentsContext();
            var studentCourse = from c in db.StudentCourse
                                where c.StudentId == profileID
                                select new
                                {
                                    CourseId = c.CourseId,
                                    Grade = c.Grade,
                                };
            var studentCourseList = studentCourse.ToList();
            foreach (var item in studentCourseList)
            {
                var course = from c in db.Courses
                             where c.CourseId == item.CourseId
                             select c.CourseName;
                var courseName = course.FirstOrDefault();
                var itemToAdd = new
                {
                    CourseName = courseName,
                    Grade = item.Grade,
                };
                profileCourses.Items.Add(itemToAdd);
            }
        }
    }
}
