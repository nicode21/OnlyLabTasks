using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Nicat","Novruzzade",21,2000,"Isci");
            emp1.GetInformation();

            Students stu1 = new Students("Nicat","Novruzzade",21,100,true);
            stu1.GetInformation();
            Person person1 =new Person("Nicat","Novruzzade",21);
            person1.GetInformation();
        }
    }
}
