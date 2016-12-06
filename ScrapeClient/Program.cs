using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a url: ");
            string url = Console.ReadLine();

            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage(url);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
