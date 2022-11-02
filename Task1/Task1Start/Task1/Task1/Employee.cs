using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Employee : Person
    {
        public int Salary { get; set; }

        public string Position { get; set; }

        public override void GetInformation()
        {            
            Console.WriteLine($"{name} - {surname} - {age} - {Salary} - {Position}");            
        }

        public Employee(string name,string surname,int age,int salary,string position) : base(name,surname,age)
        {
            Salary=salary;
            Position=position;
            
        }
    }
}
