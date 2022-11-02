using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Universities
    {
        public static int UStId { get; set; }
        public int UId { get; set; }
        public static Universities[] universities = new Universities[0];
        public string UniName { get; set; }


        public Universities(string name)
        {
            UniName= name;
            UStId++;
            UId = UStId;
        }
        

        public void Add(Universities university)
        {
            Array.Resize(ref universities, universities.Length + 1);
            universities[universities.Length - 1] = university;

        }


        public void GetFacultyInfo()
        {

            Console.WriteLine($"{UId} --> {UniName}");

        }


        public static void GetAllFacultiesInfo()
        {
            foreach (var item in universities)
            {
                Console.WriteLine($"{item.UId} --> {item.UniName}");
            }
        }

    }
}
