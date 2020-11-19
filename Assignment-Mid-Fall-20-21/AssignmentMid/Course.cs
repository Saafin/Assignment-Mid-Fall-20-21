using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Course
    {
        private string courseName;
        private string courseId;
        Section[] sectionName = new Section[5];
        private int countSection = 0;

        public void getCname(String n)
        {
            courseName = n;
        }
        public String setcourseName()
        {
            return courseName;
        }
        public void getcourseId(String id)
        {
            courseId = id;
        }
        public String setcourseId()
        {
            return courseId;
        }
        public Course(string cn, string cid)
        {
            getCname(cn);
            getcourseId(cid);
        }

        public void AddSection(Section sn)

        {

            sectionName[countSection++] = sn;
        }
        public void ShowSectionFaculty()
        {
         for(int i=0;i<10;i++)
            {
                if (sectionName[i] != null)
                {
                    sectionName[i].ShowDetails();
                }
                else { break; }
            }
        }
    }
}
