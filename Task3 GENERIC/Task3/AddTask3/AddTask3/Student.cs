using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Student
    {
        public int Id { get; set; }
        public static int SId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int AvarageMArk { get; set; }

        public Student(string name,string surname,int age,int avarageMark)
        {
            Name=name;
            Surname=surname;
            Age=age;
            AvarageMArk=avarageMark;
            SId++;
            Id = SId;
        }
    }
}
