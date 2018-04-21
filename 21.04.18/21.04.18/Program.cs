using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card("Emin","Babayev");
            card.Amount = 5000;
            card.ExpireDate = DateTime.Now;

            Card card1 = new Card("Yasin", "Mehdiyev");
            card1.Amount = 4000;
            card1.ExpireDate = DateTime.Now;

            List<Card> cards = new List<Card>();
            cards.Add(card);
            cards.Add(card1);

            List<Virtual_Card> vc = new List<Virtual_Card>();

            string selectText = "";
            int select = 0;
            do
            {
                Console.WriteLine("1. Cards");
                Console.WriteLine("2. Virtual Cards");
                Console.WriteLine("3. Create virtual card");
                Console.WriteLine("4. Delete virtual card");
                Console.WriteLine("5. Xercle");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Seciminizi edin");
                selectText = Console.ReadLine();
                Console.WriteLine("=========================================================");
                while (!int.TryParse(selectText, out select))
                {
                    Console.WriteLine("Seciminiz reqem olmalidir");
                    selectText = Console.ReadLine();
                }

                switch (select)
                {
                    case 1:
                        int i = 1;
                        foreach (var kart in cards)
                        {
                            
                            Console.WriteLine( i+ ". "+kart.Name + " " + kart.Surname);
                            Console.WriteLine(kart.Amount);
                            Console.WriteLine(kart.ExpireDate);
                            Console.WriteLine("===========================================");
                            i++;
                        }

                        break;
                      
                    case 2:
                        foreach (Virtual_Card item in vc)
                        {
                            Console.WriteLine(item.Name+ " "+item.Surname+ " "+item.code);
                        }
                        break;
                       
                    case 3:
                         i = 1;
                        foreach (var kart in cards)
                        {

                            Console.WriteLine(i + ". " + kart.Name + " " + kart.Surname);
                            Console.WriteLine(kart.Amount);
                            Console.WriteLine(kart.ExpireDate);
                            Console.WriteLine("===========================================");
                            i++;
                        }
                        Console.WriteLine("Hansi card a visual card elave etmek isteyirsen");
                        int nomre = 0;
                        string strnomre = Console.ReadLine();
                        while(!int.TryParse(strnomre,out nomre))
                        {
                            Console.WriteLine("Duzgun secim et");
                            strnomre = Console.ReadLine(); 
                        }
                        cards.Add(cards[nomre-1]);
                        Console.WriteLine(cards[nomre-1].Name+" visual card elave olundu ");
                        

                        Console.WriteLine("Ad elave et");
                        string name = Console.ReadLine();
                        Console.WriteLine("Soyad elave et");
                        string surname = Console.ReadLine();
                        Virtual_Card  virtcard = new Virtual_Card(name,surname);
                        Console.WriteLine(virtcard.code);
                        vc.Add(virtcard);
                       
                        break;
                    case 4:
                     
                        break;
                    case 5:
                     
                        break;
                    default:
                        break;
                }

            } while (select != 0);
        }
    }
}
