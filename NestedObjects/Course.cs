using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// Course title 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Number of credit for course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// Course description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Instructor who teaches course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

    }
}
