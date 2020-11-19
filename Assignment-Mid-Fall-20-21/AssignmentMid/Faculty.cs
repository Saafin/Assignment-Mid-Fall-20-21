using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Faculty
    {
        private string Fname;
        private string Fid;
        public float Counttime;
        Section[] sectionName = new Section[5];
        private int countSection = 0;

        public void getFname(String nm)
        {
            Fname = nm;
        }
        public String setFname()
        {
            return Fname;
        }
        public void getFid(String id)
        {
            Fid = id;
        }
        public String setFid()
        {
            return Fid;
        }
        public float TotalHourOfClass
        {
            get { return Counttime; }
            set { Counttime = value; }
        }
        public Faculty(string teacherName, string teacherId, float totalHourOfClass)
        {
            Fname = teacherName;
            Fid = teacherId;
            Counttime = totalHourOfClass;
        }

        public void AddSection(Section sectionName)
        {
            this.sectionName[countSection] = sectionName;
            countSection++;
            Counttime += 2.0f;
        }

        public void ShowFInfo()
        {
            Console.WriteLine("Teacher's Name: " + Fname);
            Console.WriteLine("Teacher's Id: " + Fid);
        }

        public void ShowSectionDetails()
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
