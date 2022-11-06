using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Room
    {
        public int Id { get; set; }
        public static int SId { get; set; }

        public int RoomNo { get; set; }

        public int Capacity { get; set; }


        public Room(int roomNo,int capacity)
        {
            RoomNo=roomNo;
            Capacity=capacity;
            SId++;
            Id = SId;
        }
    }
}
