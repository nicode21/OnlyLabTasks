using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Universities
    {
        public static int UStId { get; set; }
        public int UId { get; set; }
        //public static Faculties[] Suniversities = new Faculties[0];
        public Faculties[] universities = new Faculties[0];
        public string UniName { get; set; }


        public Universities(string name)
        {
            UniName= name;
            UStId++;
            UId = UStId;
            //Suniversities=universities;
        }
        

        public void Add(Faculties faculties)
        {
            Array.Resize(ref universities, universities.Length + 1);
            universities[universities.Length - 1] = faculties;
        }

        public void GetUniInfo()
        {
            Console.WriteLine($"{UId} : {UniName}");


            foreach (Faculties item in universities)
            {
                //Console.WriteLine($"{item.Fid} - {item.FacultyName} \n\n");

                item.GetFacultyInfo();
                
            }
            //Console.WriteLine("\n\n\n\n");
        }

        public Faculties[] UniversityInfo()
        {
            return universities;
        }

    }
}
