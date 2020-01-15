using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// .Represents a single college Course
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The title of the course.
        /// Ex. Programming Fundamentals 
        /// </summary>
        public string CourseTitle { get; set; }

        /// <summary>
        /// The text description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits earned from completing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The unigue course ID assigned to the course
        /// </summary>
        public int CourseId { get; set; }
    }
}
