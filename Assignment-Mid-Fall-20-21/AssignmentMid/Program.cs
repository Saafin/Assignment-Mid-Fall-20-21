using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Department Info input***************");
            Console.WriteLine("Enter Department name: ");
            String dn = Console.ReadLine();
            Department d = new Department(dn);
            Course oop2 = new Course("Course1", "Courseid");
            Course oop1= new Course("Course1", "Courseid");
            d.AddCourse(oop2);
            d.AddCourse(oop1);
            Section A = new Section("A");
            oop1.AddSection(A);
            oop2.AddSection(A);
            Faculty fac = new Faculty("Safin", "1010101010", 9.5f);
            fac.AddSection(A);
            A.AddTeacher(fac);
            Console.WriteLine("Department name: ");
            d.ShowDInfo();
            oop1.ShowSectionFaculty();
            Console.WriteLine("\nFaculty object");
            fac.ShowSectionDetails();
            Console.ReadLine();
        }
   
    }
}
