using System;
using System.Collections.Generic;

namespace AddTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee("Nicat","Novruzzade",21,1000);
            Employee emp2 = new Employee("Hesen","Qarayev",25,1000);
            Employee emp3 = new Employee("Ramazan","Mustafayev",11,1000);
            Faculty faculty1 = new Faculty("Huquqsunas");
            Faculty faculty2 = new Faculty("muhendis");
            Faculty faculty3 = new Faculty("hekim");
            Product prod1 = new Product("Alma",50,2,false);
            Room room1 = new Room(243,4);
            Student stu1 = new Student("Resul", "Hesenov",15,100);
            University uni1 = new University("BDU",500,200);


            Lists<Employee> emplist = new Lists<Employee>();

            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist.Add(emp3);

            foreach (var item in emplist.CustomList)

            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Surname} - {item.Age} - {item.Salary}");

            }
            
            Lists<Faculty> facultylist = new Lists<Faculty>();

            facultylist.Add(faculty1);
            facultylist.Add(faculty2);
            facultylist.Add(faculty3);

            foreach (var item in facultylist.CustomList)

            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }


            Lists<string> strs = new Lists<string>();

            string str1 = "asdasd";
            string str2 = "asdasdasdasd;";
            string str3 = "asdaasdsadasdasd;";

            strs.Add(str1);
            strs.Add(str2);
            strs.Add(str3);

            foreach (var item in emplist.CustomList)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in strs.CustomList)
            {
                Console.WriteLine(item);
            }
            foreach (var item in emplist.CustomList)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}
