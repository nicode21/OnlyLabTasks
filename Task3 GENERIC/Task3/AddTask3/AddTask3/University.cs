using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class University
    {
        public int Id { get; set; }
        public static int SId { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int PassingScore { get; set; }

        public University(string name,int capacity,int passingScore)
        {
            Name=name;
            Capacity=capacity;
            PassingScore=passingScore;
            SId++;
            Id = SId;
        }
    }
}
