using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3inClass
{
    public class studentGrading
    {
        /*Write a program that allows a teacher to enter in a N-number of students. For each student
       ask the teacher to enter in their name and final score for the class. When the teacher is done
       entering the data, print the highest grade in the class, and the average grade for the class*/

        public studentGrading()
        {

        }
        public studentGrading( string _name = "a", double _grades=0.0)
        {
            name = _name;
            grades = _grades;
        }
        public string name { get; set; }
        public double grades { get; set; }

        public List<studentGrading> studentList = new List<studentGrading>{};
    }
}
