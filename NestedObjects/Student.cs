using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Student
    {
        /// <summary>
        /// Constructor that sets default advisor
        /// </summary>
        public Student()
        {
            AssignedAdvisor = new Advisor();
        }
        
        /// <summary>
        /// Property: First and last name of student
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Date of birth of student
        /// </summary>
        public DateTime DateofBirth { get; set; }

        public Advisor AssignedAdvisor { get; set; }


    }
}
