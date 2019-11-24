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
                IdController.Existe = true;
                SetOpsStats(plat, id);
            } else if (value.InnerText.Equals("404 Not Found. We are unable to find your profile."))
            {
                IdController.Existe = false;
            }
                        
        }

        private static void SetOpsStats(string plat, string id)
        {
            string url = "https://r6.tracker.network/profile/" + plat + "/" + id + "/operators";

            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var op_atq = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[1]/span");
            var op_atq_time = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[2]");
            var op_atq_kd = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[5]");
            var op_atq_wins = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[6]");
            var op_atq_losses = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[1]/td[7]");

            var op_def = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[1]/span");
            var op_def_time = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[2]");
            var op_def_kd = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[5]");
            var op_def_wins = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[6]");
            var op_def_losses = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[3]/div[2]/table/tbody/tr[1]/td[7]");

            IdController.OpAtq = op_atq.FirstOrDefault().InnerText.Trim();
            IdController.OpAtqTime = op_atq_time.FirstOrDefault().InnerText;
            IdController.OpAtqKD = op_atq_kd.FirstOrDefault().InnerText.Trim();
            IdController.OpAtqWins = op_atq_wins.FirstOrDefault().InnerText.Trim();
            IdController.OpAtqLosses = op_atq_losses.FirstOrDefault().InnerText.Trim();

            IdController.OpDefTime = op_def_time.FirstOrDefault().InnerText.Trim();
            IdController.OpDefKD = op_def_kd.FirstOrDefault().InnerText.Trim();
            IdController.OpDefWins = op_def_wins.FirstOrDefault().InnerText.Trim();
            IdController.OpDefLosses = op_def_losses.FirstOrDefault().InnerText.Trim();

            IdController.WinRatio();

            if (op_def.FirstOrDefault().InnerText.Trim().Equals("J&#196;GER"))
            {
                IdController.OpDef = "JAGER";
            }
            else
            {
                IdController.OpDef = op_def.FirstOrDefault().InnerText.Trim();
            }
        }
    }
}
