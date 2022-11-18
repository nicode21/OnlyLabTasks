using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Lists <T>
    {
        public int Id { get ; set ; }
        public static int SId { get ; set ; }
        public T[] CustomList ;

        public Lists()
        {
            CustomList = new T[0];
            SId++;
            Id = SId;
        }


        public void Add(T item)
        {
            Array.Resize(ref CustomList, CustomList.Length+1 );
            CustomList[CustomList.Length-1] = item;

        }

        public T[] GetAll()
        {
            return CustomList;
        }
    }
}
