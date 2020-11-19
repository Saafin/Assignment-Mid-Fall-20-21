using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Department
    {
        private string Dname;
        Course[] courseName = new Course[50];
        private int countCourse = 0;

        public void getDname(String n)
        {
            Dname = n;
        }
        public String setDname()
        {
            return Dname;
        }
        public Department(string dn)
        {
            Dname = dn;
        }

        public void ShowDInfo()
        {
            Console.WriteLine(Dname);
        }
        public void AddCourse(Course cN)
        {
            courseName[countCourse++] = cN;
        }
    }
}
