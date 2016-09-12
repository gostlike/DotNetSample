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
        public Student(Course course)
        {
            this.course = course;
        }

        #region Property,Accessor Sample Code
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

        #region Relation Association Sample Code           
        // 取得課程名稱               
        public string getCourseName(Course course)
        {
            return course.Name;
        }
        #endregion

        #region Relation Aggregation Sample Code                
        private Course course2;        
        // 選課        
        public void setCourse(Course course) {
            this.course2 = course;
        }
        #endregion

        #region Relation Compostion Sample Code
        // Compostion
        private Course course = new Course();
        #endregion
    }
}
