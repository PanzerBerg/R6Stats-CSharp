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
            var ops = doc.DocumentNode.SelectSingleNode("/html/body/div[2]/div[3]/div/div[1]");

            if (value == null)
            {
                IdController.SetExiste(true);
                SetOps(plat, id);
            } else if (value.InnerText.Equals("404 Not Found. We are unable to find your profile."))
            {
                IdController.SetExiste(false);
            }
                        
        }

        private static void SetOps(string plat, string id)
        {
            string url = "https://r6.tracker.network/profile/" + plat + "/" + id + "/operators";

            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var op_atq = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[1]/span");
            var op_def = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[1]/span");

            IdController.SetOpAtq(op_atq.FirstOrDefault().InnerText.Trim());
            if (op_def.FirstOrDefault().InnerText.Trim().Equals("J&#196;GER"))
            {
                IdController.SetOpDef("JAGER");
            }
            else
            {
                IdController.SetOpDef(op_def.FirstOrDefault().InnerText.Trim());
            }
        }
    }
}
