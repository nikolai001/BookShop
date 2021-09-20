using System;
using BookShop.Models;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Store store = new Store();

        StartOfCode:
            int UserChoice;

            Console.WriteLine("Velkommen til das butikko");
            Console.WriteLine("Vil du søge tast 1");
            Console.WriteLine("Vil du se lager af aviser tast 2");
            Console.WriteLine("Vil du se lager af bøger tast 3");

            string Line = Console.ReadLine();

            try
            {
                UserChoice = int.Parse(Line);
            }
            catch
            {
                Console.WriteLine("Indtast kun tal");
                goto StartOfCode;
            }

            if (UserChoice == 1)
            {
                store.Search();
            }
            else if (UserChoice == 2)
            {
                store.CheckBookStock();
            }
            else if (UserChoice == 3)

            {
                store.CheckPaperStock();
            }
            else if (UserChoice > 3)
            {
                Console.WriteLine("Valg skal være inden for valg mulighederne!");
                goto StartOfCode;
            }
        }
    }
}
