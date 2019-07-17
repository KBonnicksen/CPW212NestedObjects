using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Instructor> instructors = new List<Instructor>();

            PopulateInstructorTestData(instructors);

            //Binds ENTIRE OBJECT
            lstInstructors.DataSource = instructors;
                                           //Displays full name
            lstInstructors.DisplayMember = nameof(Instructor.FullName);
        }

        private void PopulateInstructorTestData(List<Instructor> instructors)
        {
            Instructor ken = new Instructor()
            {
                Email = "Ken@cptc.edu",
                FullName = "Dr. Kenneth Meerdink"
            };

            List<Course> kenCourses = new List<Course>()
            {
                new Course()
                {
                    Title = "Data Structures",
                    CourseNumber = "CPW 245", 
                    Roster = new List<Student>()
                    {
                        new Student("Jim Halpert"),
                        new Student("Pam Halpert")
                    }
                },
                new Course()
                {
                    Title = "Java II",
                    CourseNumber = "CPW 143",
                    Roster = new List<Student>()
                    {
                        new Student("Dwight Schrute"),
                        new Student("Michael Scott")
                    }
                }
            };

            ken.CourseLoad = kenCourses;

            instructors.Add(ken);
        }

        private void LstInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor currInstructor = (Instructor) lstInstructors.SelectedItem;

            lstCourses.DataSource = currInstructor.CourseLoad;
            lstCourses.DisplayMember = nameof(Course.CourseDisplay);

        }

        private void LstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCourses.SelectedIndex < 0)
            {
                return;
            }
            Course currCourse = (Course)lstCourses.SelectedItem;

            lstStudents.DataSource = currCourse.Roster;
            lstStudents.DisplayMember = nameof(Student.FullName);
        }
    }
}
