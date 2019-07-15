using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        private string _fullName;
        private string _email;

        public Student(string fullName)
        {
            FullName = fullName;
        }

        /// <summary>
        /// The legal first and last
        /// ex. John Doe
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FullName cannot be null or whitespace");
                }
                _fullName = value;
            }
        }

        /// <summary>
        /// The school provided student email address
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {   //Maybe use REGEX for more strict validation
                if (value.EndsWith("Student.cptc.edu"))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Email must end with @student.cptc.edu");
                }
            }
        }

        /// <summary>
        /// Students mailing address
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// Home phone number of the student
        /// </summary>
        public string Phone { get; set; }
    }
}
