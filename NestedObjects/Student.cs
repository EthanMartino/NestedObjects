﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    public class Student
    {
        /// <summary>
        /// The unique identifier for students.
        /// This number is generated by the DB.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The first and last name of the student.
        /// Ex. John Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The date the student was born.
        /// Time is ignored
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// The courses the student is currently enrolled in
        /// </summary>
        public List<Course> Schedule { get; set; }
    }
}
