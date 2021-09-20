using System;

namespace BookShop.Models
{
    public class Publication
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public decimal Price { get; set; }

        // constructor

        public Publication()
        {

        }
    }
}
