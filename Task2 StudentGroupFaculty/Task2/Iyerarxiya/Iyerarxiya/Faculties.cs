using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Faculties 
    {
        public static int FStid { get; set; }
        public int Fid { get; set; }

        //public static Groups[] Sfaculties = new Groups[0]; 

        public Groups[] faculties = new Groups[0]; 
        public string FacultyName { get; set; }

        public Faculties(string name)
        {
            FacultyName = name;
            FStid++;
            Fid = FStid;

            //Sfaculties = faculties;
        }

        public void Add(Groups group)
        {
            Array.Resize(ref faculties, faculties.Length + 1);
            faculties[faculties.Length - 1] = group;

        }


        public void GetFacultyInfo()
        {
            Console.WriteLine($"{Fid} : {FacultyName} ");


            foreach (Groups item in faculties)
            {
                //Console.WriteLine($"{item.GId} - {item.GroupName} \n\n");

                //foreach (var iten in Students)
                //{
                //    Console.WriteLine($"{iten.Id} - {iten.Name} - {iten.Surname} - {iten.Age}");
                //}

                item.GetGroupInfo();

            }
            //Console.WriteLine("\n\n\n\n");
            
            //int[] items = { 10, 100, 1000 };
            //// Display elements with ForEach.
            //Array.ForEach(items, element => Console.WriteLine(
            //    "Element is " + element));
        }

        public Groups[] FacultyInfo()
        {
            return faculties;
        }

    }
}
