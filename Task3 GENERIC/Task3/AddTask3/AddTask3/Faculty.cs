using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Faculty
    {
        public int Id { get; set; }
        public static int SId { get; set; }
        public string Name { get; set; }


        public Faculty(string name)
        {
            Name = name;
            SId++;
            Id = SId;
        }
    }
}
