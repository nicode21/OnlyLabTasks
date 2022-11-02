using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Person
    {
        public string name { get; set; }

        public string surname { get; set; }

        public int age { get; set; }

        
        public virtual void GetInformation()
        {
            Console.WriteLine($"{name} - {surname} - {age}");

        }
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
                        
        }




    }
}
