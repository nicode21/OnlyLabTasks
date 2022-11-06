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

        public int AvarageMark { get ; set ; }

        public bool IsGraduated { get ; set ; }

        public Students(string name,string surname,int age,int avarageMark,bool isGraduated)
        {
            

            Name=name;
            Surname=surname;
            Age = age;
            AvarageMark=avarageMark;
            IsGraduated=isGraduated;

            SStId++;

            Id = SStId;
        }

        public void GetStudentInfo()
        {
            
            Console.WriteLine($"{Id} --> {Name} - {Surname} - {Age} - Mark : {AvarageMark} - Graduated : {IsGraduated}");
            
        }


        public string StudentInfo()
        {
            return $"{Id} - {Name} - {Surname} - {Age} - Mark : {AvarageMark} - Graduated : {IsGraduated}";
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
