using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApopheniaScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get leagues

            // Get schedule
            ScrapePage getSchedule = new ScrapePage();
            var scheduleData = getSchedule.GetPageData("https://dmyha.pucksystems2.com/schedule/day/league_instance/78964");

            // Parse Schedule
            Parsers.ScheduleParser newParser = new Parsers.ScheduleParser();
            newParser.ParseSheetData(scheduleData);

            // Get sheet from schedule

            //ScrapePage getData = new ScrapePage();
            //var siteData = getData.GetPageData("https://dmyha.pucksystems2.com/game/game_sheet/22772996");

            //// Parse sheet data
            //Parsers.StatSheetParser newParser = new Parsers.StatSheetParser();
            //newParser.ParseSheetData(siteData);

            //Console.Write(siteData);
            //Console.ReadKey();
        }
    }
}
