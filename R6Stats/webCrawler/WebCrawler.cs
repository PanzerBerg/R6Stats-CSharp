using HtmlAgilityPack;
using R6Stats.controllers;
using R6Stats.controllers.attackers;
using System.Linq;
using System.Threading.Tasks;

namespace R6Stats.webCrawler
{
    static class WebCrawler
    {
        private static string opsUrl = "";

        public static Task StartCrawlerAsync(string plat, string id)
        {
            return Task.Run(() => StartCrawler(plat, id));
        }

        public static Task AttackersAsync()
        {
            return Task.Run(() => Attackers());
        }

        public static Task DefendersAsync()
        {
            return Task.Run(() => Defenders());
        }

        public static void StartCrawler(string plat, string id)
        {
            
            string url = "https://r6.tracker.network/profile/" + plat + "/" + id;

            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var value = doc.DocumentNode.SelectSingleNode("/html/body/div[2]/div[3]/div/div[1]");

            if (value == null)
            {
                IdController.Existe = true;
                SetOpsStats(plat, id);
                SetContaStats(url);
                IdController.WinRatio();
            }
            else if (value.InnerText.Equals("404 Not Found. We are unable to find your profile."))
            {
                IdController.Existe = false;
            }
                        
        }

        private static void SetContaStats(string url)
        {
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(url);

            var contaWins = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[3]/div[1]/div[2]/div[2]/div/div[5]/div[2]");
            var contaLosses = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[3]/div[1]/div[2]/div[2]/div/div[6]/div[2]");
            var contaKD = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[3]/div[1]/div[2]/div[2]/div/div[3]/div[2]");

            var contaNome = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[1]/div/h1/span");

            IdController.ContaWins = contaWins.FirstOrDefault().InnerText.Trim();
            IdController.ContaLosses = contaLosses.FirstOrDefault().InnerText.Trim();
            IdController.ContaKD = contaKD.FirstOrDefault().InnerText.Trim();

            IdController.ContaName = contaNome.FirstOrDefault().InnerText.Trim();
        }

        private static void SetOpsStats(string plat, string id)
        {
            string url = "https://r6.tracker.network/profile/" + plat + "/" + id + "/operators";
            opsUrl = url;

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

            if (op_def.FirstOrDefault().InnerText.Trim().Equals("J&#196;GER"))
            {
                IdController.OpDef = "JAGER";
            }
            else
            {
                IdController.OpDef = op_def.FirstOrDefault().InnerText.Trim();
            }
        }

        private static void Attackers()
        {
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(opsUrl);

            for (int i = 1; i <= 25; i++) {
                string opperator = "";

                var op = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[1]/span");
                var timePlayed = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[2]");
                var kills = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[3]");
                var deaths = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[4]");
                var kd = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[5]");
                var wins = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[6]");
                var losses = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[7]");
                var meleeKills = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[9]");
                var headshots = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[10]");
                var dbnos = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[11]");
                var GadgetUses = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[2]/div[2]/div[1]/div[2]/div[2]/table/tbody/tr[" + i + "]/td[13]");
                opperator = op.FirstOrDefault().InnerText.ToLower();

                switch (opperator)
                {
                    case "amaru":
                        
                        break;
                    case "ash":
                        break;
                    case "blackBeard":
                        break;
                    case "blitz":
                        break;
                    case "buck":
                        break;
                    case "capitao":
                        break;
                    case "dokkaebi":
                        break;
                    case "finka":
                        break;
                    case "fuze":
                        break;
                    case "glaz":
                        break;
                    case "gridlock":
                        break;
                    case "hibana":
                        break;
                    case "iq":
                        break;
                    case "jackal":
                        break;
                    case "kali":
                        break;
                    case "lion":
                        break;
                    case "maverick":
                        break;
                    case "montagne":
                        break;
                    case "nokk":
                        break;
                    case "nomad":
                        break;
                    case "sledge":
                        break;
                    case "thatcher":
                        break;
                    case "thermite":
                        break;
                    case "twitch":
                        break;
                    case "ying":
                        break;
                    case "zofia":
                        break;
                }

            }
        }

        private static void Defenders()
        {
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(opsUrl);

            string opperators = "";

            switch (opperators)
            {
                case "alibi":
                    break;
                case "bandit":
                    break;
                case "castle":
                    break;
                case "caveira":
                    break;
                case "clash":
                    break;
                case "doc":
                    break;
                case "echo":
                    break;
                case "ela":
                    break;
                case "frost":
                    break;
                case "goyo":
                    break;
                case "jager":
                    break;
                case "kaid":
                    break;
                case "kapkan":
                    break;
                case "lesion":
                    break;
                case "maestro":
                    break;
                case "mira":
                    break;
                case "mozzie":
                    break;
                case "mute":
                    break;
                case "pulse":
                    break;
                case "rook":
                    break;
                case "smoke":
                    break;
                case "tatchanka":
                    break;
                case "valkyrie":
                    break;
                case "vigil":
                    break;
                case "wamai":
                    break;
                case "warden":
                    break;

            }
        }
    }
}
