using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ApopheniaScraper.Parsers
{
    public class ScheduleParser
    {
        public void ParseSheetData(string scrapedText)
        {
            HtmlDocument pageDocument = new HtmlDocument();
            pageDocument.LoadHtml(scrapedText);

            //var gameDate = GetXrefData(pageDocument, Constants.StatScraperConst.GAME_DATE);
            //Console.WriteLine("Schedule:  " + gameDate + " " + gameTime);

            Console.Write(scrapedText);
            Console.ReadKey();
        }

        private string GetDayUrls(string inputData)
        {
            // Get each href tag that is of class="game game_link_referrer"
            // Cycle through each date href to get to the schedule page for each



            return "";
        }

        private string GetXrefData(HtmlDocument docText, string xrefConst)
        {
            return docText.DocumentNode.SelectSingleNode(xrefConst).InnerText;
        }
    }
}
