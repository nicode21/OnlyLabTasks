using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.salary = 2000;
            emp1.position = "Isci";
            emp1.GetInformation("Nicat","Novruzzade",21);


            Students stu1 = new Students();

            stu1.avarageMark = 100;
            stu1.IsGraduated = true;
            stu1.GetInformation("Nicat","Novruzzade",21);
        }
    }
}
