using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Students : Person
    {        
        public int AvarageMark { get; set; }
        public bool IsGraduated { get; set; }


        public override void GetInformation()
        {            
            Console.WriteLine($"{name} - {surname} - {age} - {AvarageMark} - {IsGraduated}");
        }

        public Students(string name , string surname,int age,int avarageMark,bool isGraduated) : base(name,surname,age)
        {
            AvarageMark = avarageMark;
            IsGraduated=isGraduated;
            
        }

    }
}
