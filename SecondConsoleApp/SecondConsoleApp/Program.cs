using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(IntLength(255));
            //}
            //public static int IntLength(int a)
            //{
            //    int count = 0;
            //    while (a > 0)
            //    {
            //        a = (a - (a % 10)) / 10;
            //        count++;
            //    }
            //    return count;

            Box b = new Box(5,3,2);
            Console.WriteLine(b.Result);
    }
      

    }
}
