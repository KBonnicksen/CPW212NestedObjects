using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// An individual instructor
    /// </summary>
    class Instructor
    {
        public Instructor()
        {
            CourseLoad = new List<Course>();
        }

        /// <summary>
        /// The official @cptc.edu work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The location of the office in building/room format
        /// ex. B11R112
        /// </summary>
        public string OfficeLocation { get; set; }

        /// <summary>
        /// The unique 4 digit extension given to each Instructor
        /// </summary>
        public string OfficePhone { get; set; }

        /// <summary>
        /// Legal first and last name of the instructor
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The courses the instructor is currently teaching
        /// </summary>
        public List<Course> CourseLoad { get; set; } //should initialize

        public void  AddCourse(Course c)
        {
            CourseLoad.Add(c);
        }
    }
}
