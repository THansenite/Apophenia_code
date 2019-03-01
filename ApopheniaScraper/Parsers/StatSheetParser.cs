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

            var gameDate = GetXrefData(pageDocument, Constants.StatScraperConst.GAME_DATE);
            var gameTime = GetXrefData(pageDocument, Constants.StatScraperConst.GAME_TIME);
            var homeTeam = GetXrefData(pageDocument, Constants.StatScraperConst.HOME_TEAM);
            var awayTeam = GetXrefData(pageDocument, Constants.StatScraperConst.AWAY_TEAM);

            var homeScore = GetXrefData(pageDocument, Constants.StatScraperConst.HOME_SCORE);
            var awayScore = GetXrefData(pageDocument, Constants.StatScraperConst.AWAY_SCORE);
            var refs = GetXrefData(pageDocument, Constants.StatScraperConst.REFEREES);

            Console.WriteLine("Schedule:  " + gameDate + " " + gameTime);
            Console.WriteLine("Home Team: " + homeTeam + " - " + homeScore);
            Console.WriteLine("Away Team: " + awayTeam + " - " + awayScore);
            Console.WriteLine("Referees:  " + refs);
            Console.ReadKey();
        }

        private string GetXrefData(HtmlDocument docText, string xrefConst)
        {
            return docText.DocumentNode.SelectSingleNode(xrefConst).InnerText;
        }
    }
}
