using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Employee : Person
    {
        public int salary { get; set; }

        public string position { get; set; }

        public override void GetInformation(string name,string surname,int age)
        {
            int salary = this.salary;
            string position = this.position;
            Console.WriteLine($"{name} {surname} {age} {salary} {position}");
        }

        
    }
}
