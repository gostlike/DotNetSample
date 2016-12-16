using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // Class definition.
    public class Student
    {
        Course course;
        public Student(Course course)
        {
            this.course = course;
        }

        #region Property,Accessor
        private string name ;               
        public string Name {
            //Accessor
            get { return name; }
            set { }
        }
        public Student(string stuName) {
            this.name = stuName;
        }
        #endregion
        
        /// <summary>
        /// the courses picked by the student
        /// </summary>
        private List<Course> _courses { get; set; }

        /// <summary>
        /// the major cours of the student (Compostion)
        /// </summary>
        private Course majorCourse = new Course();

        /// <summary>
        /// get Course Name (Association)
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public string GetCourseName(Course course)
        {
            return course.Name;
        }

        /// <summary>
        /// pick the course the student want (bi-directional Association , Aggregation)
        /// reference Class level 
        /// </summary>
        /// <param name="course"></param>
        public void PickCourse(Course course) {
            _courses.Add(course);
        }                              
     
    }
}
