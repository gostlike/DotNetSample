using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher
    {
        private double id;
        private string name;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }     
        public string Name { get; set; }

        public bool isAbsentToday()
        {
            return true; // or get absent status from other system.
        }
      
    }
}
