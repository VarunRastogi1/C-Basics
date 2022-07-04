using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_basics
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GPA { get; set; }
        public string Classification { get; set; }

        public Student()
        {
        }
        public Student(int studentNumber, string firstName, string lastName, int gpa, string classification)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
            Classification = classification;
        }

    }
}
