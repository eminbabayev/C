using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._18
{
    class Card
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Amount;
      

        public Card(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


    }
}
