using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Course
    {
        private double id;      
        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// the teacher of the course (Composition)
        /// </summary>
        private Teacher teacher = new Teacher();

        /// <summary>
        /// the students in the Course
        /// </summary>
        List<Student> _students { get; set; }

        //auto-implemented property
        public string Name { get; set; }
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}       

        #region Dependency ,If Class Teacher.Id type change double to int, will affect Course.TeacherId
        private double teacherId;
        public double TeacherId
        {
            get { return teacherId != 0 ? teacherId : 0; }
            set { }
        }
        public void setCourseTeacher(Teacher teacher)
        {
            this.teacherId = teacher.Id;
        }
        #endregion

        #region Dependency ,If Class Teacher.isAbsentToday refactor, will affect Course.IsCourseOpenningToday
        public bool IsCourseOpenningToday(Teacher teacher) {
            return teacher.isAbsentToday();
        }
        #endregion
        
        /// <summary>
        /// add a student to the course (bi-directional Association ,Aggregation)
        /// </summary>
        /// <param name="student"></param>
        public void AddStudents(Student student)
        {
            _students.Add(student);
        }        
        
    }
}
