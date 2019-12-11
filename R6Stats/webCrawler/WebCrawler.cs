using HtmlAgilityPack;
using R6Stats.controllers;
using R6Stats.controllers.attackers;
using R6Stats.controllers.defenders;
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
                string opperators = "";

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
                opperators = op.FirstOrDefault().InnerText.ToLower();

                switch (opperators)
                {
                    case "amaru":
                            Amaru.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Amaru.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Amaru.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Amaru.KD = kd.FirstOrDefault().InnerText.Trim();
                            Amaru.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Amaru.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Amaru.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Amaru.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Amaru.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Amaru.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "ash":
                            Ash.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Ash.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Ash.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Ash.KD = kd.FirstOrDefault().InnerText.Trim();
                            Ash.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Ash.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Ash.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Ash.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Ash.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Ash.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "blackBeard":
                            BlackBeard.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            BlackBeard.Kills = kills.FirstOrDefault().InnerText.Trim();
                            BlackBeard.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            BlackBeard.KD = kd.FirstOrDefault().InnerText.Trim();
                            BlackBeard.Wins = wins.FirstOrDefault().InnerText.Trim();
                            BlackBeard.Losses = losses.FirstOrDefault().InnerText.Trim();
                            BlackBeard.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            BlackBeard.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            BlackBeard.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            BlackBeard.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "blitz":
                            Blitz.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Blitz.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Blitz.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Blitz.KD = kd.FirstOrDefault().InnerText.Trim();
                            Blitz.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Blitz.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Blitz.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Blitz.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Blitz.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Blitz.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "buck":
                            Buck.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Buck.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Buck.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Buck.KD = kd.FirstOrDefault().InnerText.Trim();
                            Buck.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Buck.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Buck.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Buck.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Buck.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Buck.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "capitao":
                            Capitao.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Capitao.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Capitao.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Capitao.KD = kd.FirstOrDefault().InnerText.Trim();
                            Capitao.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Capitao.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Capitao.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Capitao.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Capitao.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Capitao.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "dokkaebi":
                            Dokkaebi.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.KD = kd.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Dokkaebi.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "finka":
                            Finka.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Finka.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Finka.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Finka.KD = kd.FirstOrDefault().InnerText.Trim();
                            Finka.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Finka.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Finka.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Finka.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Finka.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Finka.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "fuze":
                            Blitz.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Blitz.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Blitz.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Blitz.KD = kd.FirstOrDefault().InnerText.Trim();
                            Blitz.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Blitz.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Blitz.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Blitz.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Blitz.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Blitz.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "glaz":
                            Glaz.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Glaz.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Glaz.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Glaz.KD = kd.FirstOrDefault().InnerText.Trim();
                            Glaz.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Glaz.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Glaz.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Glaz.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Glaz.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Glaz.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "gridlock":
                            Gridlock.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Gridlock.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Gridlock.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Gridlock.KD = kd.FirstOrDefault().InnerText.Trim();
                            Gridlock.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Gridlock.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Gridlock.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Gridlock.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Gridlock.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Gridlock.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "hibana":
                            Hibana.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Hibana.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Hibana.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Hibana.KD = kd.FirstOrDefault().InnerText.Trim();
                            Hibana.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Hibana.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Hibana.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Hibana.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Hibana.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Hibana.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "iq":
                            IQ.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            IQ.Kills = kills.FirstOrDefault().InnerText.Trim();
                            IQ.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            IQ.KD = kd.FirstOrDefault().InnerText.Trim();
                            IQ.Wins = wins.FirstOrDefault().InnerText.Trim();
                            IQ.Losses = losses.FirstOrDefault().InnerText.Trim();
                            IQ.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            IQ.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            IQ.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            IQ.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "jackal":
                            Jackal.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Jackal.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Jackal.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Jackal.KD = kd.FirstOrDefault().InnerText.Trim();
                            Jackal.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Jackal.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Jackal.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Jackal.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Jackal.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Jackal.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "kali":
                            Kali.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Kali.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Kali.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Kali.KD = kd.FirstOrDefault().InnerText.Trim();
                            Kali.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Kali.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Kali.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Kali.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Kali.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Kali.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "lion":
                            Lion.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Lion.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Lion.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Lion.KD = kd.FirstOrDefault().InnerText.Trim();
                            Lion.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Lion.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Lion.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Lion.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Lion.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Lion.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "maverick":
                            Maverick.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Maverick.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Maverick.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Maverick.KD = kd.FirstOrDefault().InnerText.Trim();
                            Maverick.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Maverick.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Maverick.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Maverick.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Maverick.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Maverick.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "montagne":
                            Montagne.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Montagne.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Montagne.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Montagne.KD = kd.FirstOrDefault().InnerText.Trim();
                            Montagne.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Montagne.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Montagne.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Montagne.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Montagne.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Montagne.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "nokk":
                            Nokk.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Nokk.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Nokk.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Nokk.KD = kd.FirstOrDefault().InnerText.Trim();
                            Nokk.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Nokk.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Nokk.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Nokk.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Nokk.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Nokk.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "nomad":
                            Nomad.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Nomad.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Nomad.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Nomad.KD = kd.FirstOrDefault().InnerText.Trim();
                            Nomad.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Nomad.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Nomad.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Nomad.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Nomad.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Nomad.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "sledge":
                            Sledge.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Sledge.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Sledge.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Sledge.KD = kd.FirstOrDefault().InnerText.Trim();
                            Sledge.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Sledge.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Sledge.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Sledge.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Sledge.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Sledge.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "thatcher":
                            Thatcher.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Thatcher.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Thatcher.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Thatcher.KD = kd.FirstOrDefault().InnerText.Trim();
                            Thatcher.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Thatcher.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Thatcher.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Thatcher.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Thatcher.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Thatcher.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "thermite":
                            Thermite.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Thermite.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Thermite.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Thermite.KD = kd.FirstOrDefault().InnerText.Trim();
                            Thermite.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Thermite.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Thermite.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Thermite.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Thermite.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Thermite.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "twitch":
                            Twitch.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Twitch.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Twitch.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Twitch.KD = kd.FirstOrDefault().InnerText.Trim();
                            Twitch.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Twitch.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Twitch.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Twitch.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Twitch.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Twitch.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "ying":
                            Ying.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Ying.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Ying.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Ying.KD = kd.FirstOrDefault().InnerText.Trim();
                            Ying.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Ying.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Ying.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Ying.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Ying.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Ying.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "zofia":
                            Zofia.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Zofia.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Zofia.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Zofia.KD = kd.FirstOrDefault().InnerText.Trim();
                            Zofia.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Zofia.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Zofia.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Zofia.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Zofia.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Zofia.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                }

            }
        }

        private static void Defenders()
        {
            var htmlWeb = new HtmlWeb();
            var doc = htmlWeb.Load(opsUrl);

            for (int i = 1; i <= 25; i++)
            {

                string opperators = "";

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
                if (op.FirstOrDefault().InnerText.Trim().Equals("J&#196;GER"))
                {
                    opperators = "jager";
                }
                else
                {
                    opperators = op.FirstOrDefault().InnerText.Trim();
                }

                switch (opperators)
                {
                    case "alibi":
                            Alibi.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Alibi.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Alibi.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Alibi.KD = kd.FirstOrDefault().InnerText.Trim();
                            Alibi.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Alibi.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Alibi.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Alibi.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Alibi.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Alibi.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "bandit":
                            Bandit.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Bandit.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Bandit.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Bandit.KD = kd.FirstOrDefault().InnerText.Trim();
                            Bandit.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Bandit.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Bandit.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Bandit.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Bandit.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Bandit.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "castle":
                            Castle.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Castle.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Castle.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Castle.KD = kd.FirstOrDefault().InnerText.Trim();
                            Castle.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Castle.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Castle.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Castle.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Castle.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Castle.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "caveira":
                            Caveira.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Caveira.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Caveira.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Caveira.KD = kd.FirstOrDefault().InnerText.Trim();
                            Caveira.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Caveira.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Caveira.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Caveira.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Caveira.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Caveira.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "clash":
                            Clash.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Clash.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Clash.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Clash.KD = kd.FirstOrDefault().InnerText.Trim();
                            Clash.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Clash.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Clash.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Clash.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Clash.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Clash.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "doc":
                            Doc.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Doc.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Doc.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Doc.KD = kd.FirstOrDefault().InnerText.Trim();
                            Doc.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Doc.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Doc.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Doc.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Doc.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Doc.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "echo":
                            Echo.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Echo.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Echo.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Echo.KD = kd.FirstOrDefault().InnerText.Trim();
                            Echo.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Echo.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Echo.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Echo.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Echo.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Echo.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "ela":
                            Ela.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Ela.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Ela.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Ela.KD = kd.FirstOrDefault().InnerText.Trim();
                            Ela.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Ela.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Ela.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Ela.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Ela.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Ela.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "frost":
                            Frost.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Frost.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Frost.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Frost.KD = kd.FirstOrDefault().InnerText.Trim();
                            Frost.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Frost.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Frost.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Frost.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Frost.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Frost.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "goyo":
                            Goyo.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Goyo.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Goyo.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Goyo.KD = kd.FirstOrDefault().InnerText.Trim();
                            Goyo.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Goyo.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Goyo.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Goyo.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Goyo.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Goyo.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "jager":
                            Jager.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Jager.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Jager.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Jager.KD = kd.FirstOrDefault().InnerText.Trim();
                            Jager.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Jager.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Jager.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Jager.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Jager.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Jager.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "kaid":
                            Kaid.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Kaid.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Kaid.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Kaid.KD = kd.FirstOrDefault().InnerText.Trim();
                            Kaid.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Kaid.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Kaid.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Kaid.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Kaid.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Kaid.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "kapkan":
                            Kapkan.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Kapkan.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Kapkan.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Kapkan.KD = kd.FirstOrDefault().InnerText.Trim();
                            Kapkan.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Kapkan.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Kapkan.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Kapkan.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Kapkan.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Kapkan.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "lesion":
                            Lesion.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Lesion.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Lesion.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Lesion.KD = kd.FirstOrDefault().InnerText.Trim();
                            Lesion.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Lesion.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Lesion.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Lesion.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Lesion.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Lesion.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "maestro":
                            Maestro.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Maestro.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Maestro.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Maestro.KD = kd.FirstOrDefault().InnerText.Trim();
                            Maestro.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Maestro.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Maestro.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Maestro.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Maestro.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Maestro.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "mira":
                            Mira.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Mira.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Mira.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Mira.KD = kd.FirstOrDefault().InnerText.Trim();
                            Mira.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Mira.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Mira.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Mira.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Mira.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Mira.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "mozzie":
                            Mozzie.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Mozzie.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Mozzie.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Mozzie.KD = kd.FirstOrDefault().InnerText.Trim();
                            Mozzie.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Mozzie.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Mozzie.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Mozzie.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Mozzie.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Mozzie.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "mute":
                            Mute.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Mute.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Mute.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Mute.KD = kd.FirstOrDefault().InnerText.Trim();
                            Mute.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Mute.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Mute.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Mute.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Mute.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Mute.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "pulse":
                            Pulse.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Pulse.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Pulse.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Pulse.KD = kd.FirstOrDefault().InnerText.Trim();
                            Pulse.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Pulse.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Pulse.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Pulse.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Pulse.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Pulse.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "rook":
                            Rook.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Rook.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Rook.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Rook.KD = kd.FirstOrDefault().InnerText.Trim();
                            Rook.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Rook.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Rook.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Rook.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Rook.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Rook.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "smoke":
                            Smoke.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Smoke.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Smoke.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Smoke.KD = kd.FirstOrDefault().InnerText.Trim();
                            Smoke.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Smoke.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Smoke.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Smoke.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Smoke.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Smoke.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "tachanka":
                            Tachanka.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Tachanka.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Tachanka.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Tachanka.KD = kd.FirstOrDefault().InnerText.Trim();
                            Tachanka.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Tachanka.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Tachanka.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Tachanka.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Tachanka.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Tachanka.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "valkyrie":
                            Valkyrie.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Valkyrie.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Valkyrie.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Valkyrie.KD = kd.FirstOrDefault().InnerText.Trim();
                            Valkyrie.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Valkyrie.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Valkyrie.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Valkyrie.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Valkyrie.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Valkyrie.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "vigil":
                            Vigil.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Vigil.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Vigil.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Vigil.KD = kd.FirstOrDefault().InnerText.Trim();
                            Vigil.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Vigil.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Vigil.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Vigil.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Vigil.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Vigil.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "wamai":
                            Wamai.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Wamai.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Wamai.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Wamai.KD = kd.FirstOrDefault().InnerText.Trim();
                            Wamai.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Wamai.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Wamai.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Wamai.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Wamai.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Wamai.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                    case "warden":
                            Warden.TimePlayed = timePlayed.FirstOrDefault().InnerText.Trim();
                            Warden.Kills = kills.FirstOrDefault().InnerText.Trim();
                            Warden.Deaths = deaths.FirstOrDefault().InnerText.Trim();
                            Warden.KD = kd.FirstOrDefault().InnerText.Trim();
                            Warden.Wins = wins.FirstOrDefault().InnerText.Trim();
                            Warden.Losses = losses.FirstOrDefault().InnerText.Trim();
                            Warden.MeleeKills = meleeKills.FirstOrDefault().InnerText.Trim();
                            Warden.Headshots = headshots.FirstOrDefault().InnerText.Trim();
                            Warden.DBNOS = dbnos.FirstOrDefault().InnerText.Trim();
                            Warden.GadgetUses = GadgetUses.FirstOrDefault().InnerText.Trim();
                        break;
                }
            }
        }
    }
}
