using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Languages : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime CreatingDay { get; set; }
        public int Power { get; set; }
        public int Popularity { get; set; }


        public Languages(string name, DateTime creatingDay, int power, int popularity)
        {
            Name = name;
            CreatingDay = creatingDay;
            Power = power;
            Popularity = popularity;

        }

    }
}
