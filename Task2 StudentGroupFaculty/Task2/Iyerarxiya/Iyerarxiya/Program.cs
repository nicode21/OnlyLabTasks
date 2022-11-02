using System;

namespace Iyerarxiya
{
    class Program
    {

        //iyerarxiya qurmaq array resize methodu olur classlari istediyin tipde yaza bilerem studentler olur proplar idler falan olur id ni static artiracam qrup classi yaradirsan qrup classinda number name id olsun faculty university yaradilir miras almir unilerde facultylerde add methodu olur GetAll methodlari yaradilir
        static void Main(string[] args)
        {
            
            Students stu1 = new Students("Nicat","Novruzzade",21);

            stu1.Add(stu1);
            
            //stu1.GetAllInfo();
            

            Students stu2 = new Students("Nica", "Novrde", 20);

            //stu2.GetAllInfo();

            stu2.Add(stu2);

            //Students.GetAllStudentsInfo();


            Groups group1 = new Groups("P414");

            group1.Add(group1);

            //group1.GetGroupInfo();


            Faculties faculty1 = new Faculties("Iqtisadiyyat");

            faculty1.Add(faculty1);

            //faculty1.GetFacultyInfo();

            //Faculties.GetAllFacultiesInfo();

        }

        
        


    }
}
