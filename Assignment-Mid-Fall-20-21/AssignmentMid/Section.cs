using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Section
    {
        private String name;
        Faculty FacultyName;

        public void getSname(String n)
        {
            name = n;
        }
        public String setSname()
        {
            return name;
        }
        public Section(string sectionName)
        {
            getSname(sectionName);
        }

        public void AddTeacher(Faculty teacherName)
        {
            if (teacherName.Counttime < 21)
            {
                FacultyName = teacherName;
            }
            else
            {
                Console.WriteLine("course can't add");
            }

        }

        public void ShowDetails()
        {
            Console.WriteLine("Section:" + name);
            FacultyName.ShowFInfo();
        }
    }
}
