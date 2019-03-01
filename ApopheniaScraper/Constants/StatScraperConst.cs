using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApopheniaScraper.Constants
{
    public class StatScraperConst
    {
        // Game Data
        public const string GAME_DATE = "//*[@id=\"game_date\"]";
        public const string GAME_TIME = "//*[@id=\"game_time\"]";
        public const string HOME_TEAM = "//*[@id=\"home_team_name\"]";
        public const string AWAY_TEAM = "//*[@id=\"away_team_name\"]";

        //Final Data
        public const string REFEREES = "//*[@id=\"game_refs\"]";
        public const string HOME_SCORE = "//*[@id=\"home_team_score\"]";
        public const string AWAY_SCORE = "//*[@id=\"away_team_score\"]";
		
    }
}
