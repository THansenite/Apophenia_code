using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ApopheniaScraper.Parsers
{
    class StatSheetParser
    {
        public void ParseSheetData(string scrapedText)
        {
            HtmlDocument pageDocument = new HtmlDocument();
            pageDocument.LoadHtml(scrapedText);

            var homeTeam = pageDocument.DocumentNode.SelectSingleNode(Constants.StatScraperConst.HOME_TEAM).InnerText;
            var awayTeam = pageDocument.DocumentNode.SelectSingleNode(Constants.StatScraperConst.AWAY_TEAM).InnerText;

            Console.WriteLine("Home Team: " + homeTeam);
            Console.WriteLine("Away Team: " + awayTeam);
            Console.ReadKey();
        }
    }
}
