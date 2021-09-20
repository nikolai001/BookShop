using System;
namespace BookShop.Models
{
    public class NewsPaper : Publication
    {
        public DateTime Date { get; set; }

        public int Pages { get; set; }
    }
}
