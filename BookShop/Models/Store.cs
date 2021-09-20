using System;
using System.Collections.Generic;
namespace BookShop.Models
{
    public class Store
    {

        List<NewsPaper> newsPapers = new List<NewsPaper>();

        List<Book> books = new List<Book>();


        public Store()
        {
            // Tilføj aviser til butik
            NewsPaper politikken = new NewsPaper();
            politikken.Date = DateTime.Today;
            politikken.Id = 1;
            politikken.Pages = 34;
            politikken.Price = 30.50m;
            politikken.Publisher = "Politiken";
            politikken.Title = "Politikken";

            NewsPaper bt = new NewsPaper {
                Id = 2,
                Title = "BT",
                Publisher = "BT",
                Price = 30.50m,
                Pages = 30,
                Date = DateTime.Today
            };

            newsPapers.Add(politikken);
            newsPapers.Add(bt);

            //Add books

            Book DaVinciCode = new Book
            {
                Author = "Dan Brown",
                Id = 1,
                Isbn = 1524214,
                Price = 150.99m,
                Publisher = "Doubleday",
                Title = "Da vinci code"
            };

            Book AngelsAndDemons = new Book
            {
                Author = "Dan Brown",
                Id = 2,
                Isbn = 15895118,
                Price = 120.99m,
                Publisher = "Doubleday",
                Title = "Angels and demons"
            };


            books.Add(DaVinciCode);
            books.Add(AngelsAndDemons);

        }

        // my sweet sweet prince :(

        //public void SearchNewsPapers()
        //{
        //    Console.WriteLine("Søg efter avis");

        //    string SearchText = Console.ReadLine();

        //    foreach (var item in newsPapers)
        //    {
        //        if (SearchText.ToLower() == item.Title.ToLower())
        //        {
        //            Console.WriteLine($"Fandt avisen {item.Title}");
        //        }
        //    }
        //}

        //public void SearchBooks()
        //{
        //    Console.WriteLine("Søg efter bog");

        //    string SearchText = Console.ReadLine();

        //    foreach (var item in books)
        //    {
        //        if (SearchText.ToLower() == item.Title.ToLower())
        //        {
        //            Console.WriteLine($"Fandt bogen {item.Title} skrevet af {item.Author} med id {item.Id} og Isbn {item.Isbn} udgivet af {item.Publisher} og til prisen {item.Price}");
        //        }
        //    }
        //}

        public void Search()
        {
            Console.WriteLine("Søg bog eller avis");

            string SearchText = Console.ReadLine();

            foreach (var item in books)
            {
                if (SearchText.ToLower() == item.Title.ToLower())
                {
                    Console.WriteLine($"Fandt bogen {item.Title} skrevet af {item.Author} med id {item.Id} og Isbn {item.Isbn} udgivet af {item.Publisher} og til prisen {item.Price}");
                }
            }

            foreach (var item in newsPapers)
            {
                if (SearchText.ToLower() == item.Title.ToLower())
                {
                    Console.WriteLine($"Fandt avisen {item.Title} til {item.Price}");
                }
            }
        }

        public void CheckPaperStock()
        {
            foreach (var item in newsPapers)
            {
              Console.WriteLine($"Navn: {item.Title}, pris {item.Price} kr");
            }
        }

        public void CheckBookStock()
        {
            foreach (var item in books)
            {
                Console.WriteLine($"Navn: {item.Title}, pris {item.Price} kr");
            }
        }

    }
}
