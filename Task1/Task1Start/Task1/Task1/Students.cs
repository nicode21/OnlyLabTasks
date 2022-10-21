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

        }

        public Students(string name, string surname, int age, int avarageMark, bool IsGraduated)
        {
            GetInformation(name, surname, age);

            Console.WriteLine($"This Student : {name} - {surname} - {age} - {avarageMark} - {IsGraduated}");

        }
    }
}
