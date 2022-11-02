using System;
using System.Collections.Generic;
using System.Text;

namespace Iyerarxiya
{
    public class Groups 
    {
        //public List<Groups> groups  =  new List<Groups>();

        public static Groups[] groups = new Groups[0];

        public static int GStid { get; set; }

        public string GroupName { get; set; }
        public int GId { get; set; }

        public Groups(string name)
        {
            GroupName= name;
            GStid++;
            GId =GStid;
        }

        public void Add(Groups group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;

        }


        public void GetGroupInfo()
        {

            Console.WriteLine($"{GId} --> {GroupName}");

        }


        public static void GetAllGroupsInfo()
        {
            foreach (var item in groups)
            {
                Console.WriteLine($"{item.GId} --> {item.GroupName}");
            }
        }
    }
}
