using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._18
{
    class Virtual_Card
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ExpireDate { get; set; }
        public string code;
        public int balans;
       


        public Virtual_Card(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.ExpireDate = DateTime.Now;
            Random random = new Random();
            int num1 = random.Next(1000, 9999);
            int num2 = random.Next(1000, 9999);
            int num3 = random.Next(1000, 9999);
            int num4 = random.Next(1000, 9999);
            code = num1 + "-" + num2 + "-" + num3 + "-" + num4;
        }
    }
}
