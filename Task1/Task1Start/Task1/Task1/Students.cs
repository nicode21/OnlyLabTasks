using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Students : Person
    {        
        public int avarageMark { get; set; }
        public bool IsGraduated { get; set; }


        public override void GetInformation(string name, string surname, int age)
        {
            int avarageMark = this.avarageMark;
            bool isGraduated = this.IsGraduated;
            Console.WriteLine($"{name} {surname} {age} {avarageMark} {isGraduated}");
        }


    }
}
