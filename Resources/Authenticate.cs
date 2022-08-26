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
    public class Authenticate
    {
        public static Students userProfile;
        public static Students adminProfile;
        public void UserAuthenticate(string username, string password)
        {
            var db = new StudentsContext();
            var StudentData = from c in db.Students select c;
            List<Students> StudentList = StudentData.ToList();
            bool looking = false;
            foreach (var line in StudentList)
            {
                if (username == line.StudentUserName && password == line.StudentPassword)
                { /*
                    var query = from students in db.StudentCourse
                                join ;
                    */
                    userProfile = new Students();
                    {
                        userProfile.StudentUserName = line.StudentUserName;
                        userProfile.StudentName = line.StudentName;
                        userProfile.CurrentYear = line.CurrentYear;
                        userProfile.StudentEmail = line.StudentEmail;
                        userProfile.StudentPhone = line.StudentPhone;
                        userProfile.StudentPassword = line.StudentPassword;
                        userProfile.StudentId = line.StudentId;
                      //  userProfile.StudentCourse = line.StudentCourse;
                        new UserPersonalPage().Show();
                    };
                    looking = true;
                }
                if (looking == false)
                {
                    MessageBox.Show("Username or password is invalid");
                }
            }
        }

        public void AdminAuthenticate(string username, string password)
        {
            var db = new StudentsContext();
            var StudentData = from c in db.Students select c;
            List<Students> StudentList = StudentData.ToList();
            bool looking = false;
            foreach (var line in StudentList)
            {
                if (username == line.StudentUserName && password == line.StudentPassword && line.IsAdmin==true)
                {
                    adminProfile = new Students();
                        adminProfile.StudentUserName = line.StudentUserName;
                        adminProfile.StudentName = line.StudentName;
                        adminProfile.CurrentYear = line.CurrentYear;
                        adminProfile.StudentEmail = line.StudentEmail;
                        adminProfile.StudentPhone = line.StudentPhone;
                        adminProfile.StudentPassword = line.StudentPassword;
                        adminProfile.StudentId = line.StudentId;
                        adminProfile.StudentCourse = line.StudentCourse;
                        new AdminPersonalPage().Show();
                    looking = true;
                }
                if (looking == false)
                {
                    MessageBox.Show("Username or password is invalid");
                }

            }
        }
    
        public void RegisterNewUser(string name, string username, int year, string mail, string phone, string password)
        {
            if (name == "" || username == "" || year == null || mail == "" || phone == "" || password == "")
            {
                MessageBox.Show("One or more fields are empty", "Registration Failed");
            }
            else
            {
                var context = new StudentsContext();
                Students Entry = new Students();
                Entry.StudentName = name;
                Entry.StudentUserName = username;
                Entry.CurrentYear = year;
                Entry.StudentEmail = mail;
                Entry.StudentPhone = phone;
                Entry.StudentPassword = password;
                Entry.IsAdmin = false;

                context.Students.Add(Entry);
                context.SaveChanges();
                MessageBox.Show("Registered Succesfully");

            }
        }

        public void RegisterNewClass(string name, int hourslength, int weeklength, int credits)
        {
            if (name == "" || hourslength == null || weeklength == null || credits == null)
            {
                MessageBox.Show("One or more fields are empty", "Registration Failed");
            }
            else
            {
                var courseCreationContext = new StudentsContext();
                Courses Entry = new Courses();
                Entry.CourseName = name;
                Entry.WeeklyHours = hourslength;
                Entry.NumberOfWeeks = weeklength;
                Entry.Credits = credits;
                courseCreationContext.Courses.Add(Entry);
                courseCreationContext.SaveChanges();
                MessageBox.Show("Registered Succesfully");

            }
        }
    }
}