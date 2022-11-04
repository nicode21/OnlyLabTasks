using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Students
    {

        public static int SStId {get; set;}

        public int Id { get; set; } 

        public static Students[] _arr = new Students [0] ;

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }



        public Students()
        {

        }


        public Students(string name,string surname,int age)
        {
            

            Name=name;
            Surname=surname;
            Age = age;
            SStId++;

            Id = SStId;
        }

        

        


        public void GetAllInfo()
        {
            
            Console.WriteLine($"{Id} --> {Name} - {Surname} - {Age} ");
            
        }


        //public static void GetAllStudentsInfo()
        //{
        //    foreach (var item in _arr)
        //    {
        //        Console.WriteLine($"{item.Id} --> {item.Name} - {item.Surname} - {item.Age}");
        //    }
        //}

    }
}
