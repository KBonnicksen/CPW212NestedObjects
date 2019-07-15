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
        /// <summary>
        /// The legal first and last
        /// ex. John Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The student school provided email address
        /// </summary>
        public string Email { get; set; }

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
