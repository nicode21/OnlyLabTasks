using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Groups
    {
        //public List<Groups> groups  =  new List<Groups>();

        public static Students[] Sstudents = new Students[0];
        public  Students[] Students = new Students[0];

        public static int GStid { get; set; }

        public string GroupName { get; set; }

        public int GId { get; set; }


        public Groups()
        {

        }


        public Groups(string name)
        {
            GroupName= name;
            GStid++;
            GId =GStid;

            Sstudents = Students;
        }

        public void Add(Students student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;


        }


        public void GetGroupInfo()
        {

            Console.WriteLine($"{GId} : {GroupName} \n\n");


            foreach (var item in Students)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Surname} - {item.Age}\n\n");
            }
            Console.WriteLine("\n\n\n\n");

        }


        //public static void GetAllGroupsInfo()
        //{
        //    foreach (var item in students)
        //    {
        //        Console.WriteLine($"{item.Id} --> {item.Name} - {item.Surname} - {item.Age}");
        //    }
        //}
    }
}
