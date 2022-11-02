using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Faculties
    {
        public static int FStid { get; set; }
        public int Fid { get; set; }

        public static Faculties[] faculties = new Faculties[0]; 
        public string FacultyName { get; set; }

        public Faculties(string name)
        {
            FacultyName = name;
            FStid++;
            Fid = FStid;
        }

        public void Add(Faculties faculty)
        {
            Array.Resize(ref faculties, faculties.Length + 1);
            faculties[faculties.Length - 1] = faculty;

        }


        public void GetFacultyInfo()
        {

            Console.WriteLine($"{Fid} --> {FacultyName}");

        }


        public static void GetAllFacultiesInfo()
        {
            foreach (var item in faculties)
            {
                Console.WriteLine($"{item.Fid} --> {item.FacultyName}");
            }
        }
    }
}
