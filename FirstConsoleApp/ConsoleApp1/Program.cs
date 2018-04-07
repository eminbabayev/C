using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1   //
            //byte examresult;
            //Console.WriteLine("Please enter your result");
            //examresult = Convert.ToByte(Console.ReadLine());

            //    if (examresult > 0 && examresult < 40)
            //        Console.WriteLine("Kesildiniz,F.Her telebenin kesri olar.Kesirsiz telebe balkonsuz ev kimidi.Qalsin qelen defeye");
            //    else if (examresult >= 41 && examresult < 50)
            //        Console.WriteLine("Kecdi.D");
            //    else if (examresult >= 51 && examresult < 60)
            //        Console.WriteLine("Kecdi.C");
            //    else if (examresult >= 61 && examresult < 80)
            //        Console.WriteLine("Kecdi.B");
            //    else
            //    {
            //        Console.WriteLine("Kecdi.A");
            //    }



            //   2   //
            //int reqem;
            //for (reqem = 0; reqem <= 100; reqem++)
            //{
            //    if (reqem % 3 == 0 && reqem % 7 == 0)
            //    {
            //        Console.WriteLine(reqem + " Her ikisine bolundu");
            //    }
            //    else if (reqem % 7 == 0)
            //    {
            //        Console.WriteLine(reqem + " 7E bolundu");
            //    }
            //    else if (reqem % 3 == 0)
            //    {
            //        Console.WriteLine(reqem + " 3E bolundu");

            //    }

            //}


            //   3   //
            string reqem = Console.ReadLine();

            double input = 0;
            double newinput = 0;
            double ferq = 0;
            

            while (!double.TryParse(reqem, out input))
                 {            
                    Console.WriteLine("Duzgun reqem daxil edin");
                    reqem = Console.ReadLine();
                 }


            string tezereqem = Console.ReadLine();
            while (!double.TryParse(tezereqem, out newinput))
            {
                Console.WriteLine("Duzgun reqem daxil edin");
                tezereqem = Console.ReadLine();

            }


            if (input > 0 && newinput > 0)
            {
                if (input > newinput)
                {
                    ferq = (input - newinput)/ input * 100;
                    Console.WriteLine("Ferq:-" + ferq + "%");
                }
                else if (input == newinput)
                {
                    Console.WriteLine("Ferq yoxdur");
                }
                else
                {
                    ferq = (newinput - input) /input * 100;
                    Console.WriteLine("Ferq:+" +ferq+ "%");
                }
            }

        }


    }
    }

