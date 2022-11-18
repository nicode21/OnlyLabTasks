using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Employee
    {
        public int Id { get; set; }
        public static int SId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public double Salary { get; set; }


        public Employee(string name,string surname,int age,double salary)
        {
            Name =name;
            Surname=surname;
            Age=age;
            Salary = salary;

            SId++;
            Id=SId;
        }



    }
}
