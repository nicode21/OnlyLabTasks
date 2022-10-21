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
            
        }

        public Employee(string name , string surname,int age , int salary,string position)
        {
            GetInformation(name, surname, age);

            Console.WriteLine($"This employee : {name} - {surname} - {age} - {salary} - {position}");

        }
    }
}
