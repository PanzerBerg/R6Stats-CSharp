using HtmlAgilityPack;
using R6Stats.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace R6Stats.webCrawler
{
    static class WebCrawler
    {
        public static void StartCrawler(string plat, string id)
        {
            
            string url = "https://r6.tracker.network/profile/" + plat + "/" + id;

            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var value = doc.DocumentNode.SelectSingleNode("/html/body/div[2]/div[3]/div/div[1]");

            if (value == null)
            {
                IdController.SetExiste(true);
            } else if (value.InnerText.Equals("404 Not Found. We are unable to find your profile."))
            {
                IdController.SetExiste(false);
            }

            Console.WriteLine(value.InnerText);
            
        }
    }
}
