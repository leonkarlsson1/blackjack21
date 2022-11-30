using System;
namespace BlackJack_21
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("välkommen till 21");
            Console.WriteLine("välj ett alternativ");
            Console.WriteLine("1. Spela 21");
            Console.WriteLine("2. Visa senaste vinsten");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Avsluta programmet");
            int Val=int.Parse(Console.ReadLine());
            Random slump = new Random();

            switch(Val)
            {
                case 1:Console.WriteLine("Vi väjer 2 kort till blackjack");
                    Console.WriteLine("Summan av dinna korten:"+slump.Next(1, 11));
                    Console.WriteLine("Datorns poäng är:" + slump.Next(1, 11));
                    Console.WriteLine("Vill du ta ett till kort (Ja/Nej)");
                    break;

                case 2:Console.WriteLine("Senaste vinsten är");
                    break;

                case 3:Console.WriteLine("Spelets Regler");
                    Console.WriteLine("Målsättningen för dig som spelare är att din hand efter spelets slut ska ha ett värde som är närmare 21 än bankens hand. " +
                        "Kortens värde får dock inte vara över 21 då blir du bust och förlorar.");
                    break;

                case 4:Console.WriteLine("Programmet avslutas");
                    break;
            }


        }
    }
}
