using System;

namespace Iyerarxiya
{
    class Program
    {

        //iyerarxiya qurmaq array resize methodu olur classlari istediyin tipde yaza bilerem studentler olur proplar idler falan olur id ni static artiracam qrup classi yaradirsan qrup classinda number name id olsun faculty university yaradilir miras almir unilerde facultylerde add methodu olur GetAll methodlari yaradilir
        static void Main(string[] args)
        {
            
            Students stu1 = new Students("Nicat","Novruzzade",21);

            
            //stu1.GetAllInfo();
            

            Students stu2 = new Students("Resul", "Hesenov", 20);
            Students stu3 = new Students("Yuksel", "Atali", 20);
            Students stu4 = new Students("Ferid", "Hesenli", 20);

            //stu2.GetAllInfo();


            //Students.GetAllStudentsInfo();


            Groups group1 = new Groups("P414");

            group1.Add(stu1);

            group1.Add(stu2);

            //group1.GetGroupInfo();


            Groups group2 = new Groups("P232");

            group2.Add(stu3);

            group2.Add(stu4);

            //group2.GetGroupInfo();



            //group1.GetGroupInfo();


            Faculties faculty1 = new Faculties("Iqtisadiyyat");

            faculty1.Add(group1);

            faculty1.Add(group2);

            //faculty1.GetFacultyInfo();


            Faculties faculty2 = new Faculties("Muhendsilik");

            faculty2.Add(group1);
            faculty2.Add(group2);

            //faculty2.GetFacultyInfo();

            //Faculties.GetAllFacultiesInfo();

            Universities uni1 = new Universities("BDU");

            uni1.Add(faculty1);
            uni1.Add(faculty2);

            //uni1.GetUniInfo();


            //foreach (var item in uni1.FacultiesInfo())
            //{
            //    Console.WriteLine(item.Fid + "-" + item.FacultyName );
            //}

            foreach (var item in uni1.UniversityInfo())
            {
                Console.WriteLine($"{item.Fid} - {item.FacultyName}");
            }
            foreach (var item in group1.GroupInfo())
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Surname} - {item.Age}");
            }
            foreach (var item in faculty1.FacultyInfo())
            {
                Console.WriteLine($"{item.GId} - {item.GroupName}");
            }

        }

        
        


    }
}
