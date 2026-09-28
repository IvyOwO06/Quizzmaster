using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace score
{
    internal class Score
    {
        int scoreId = int.MinValue;
        TimeSpan score = TimeSpan.Zero;
        DateTime datePlayed = DateTime.MinValue;
        string playername = string.Empty;

        public Score(int c_scoreId, TimeSpan c_score, DateTime c_datePlayed, string c_playername)
        {
            scoreId = c_scoreId;
            score = c_score;
            datePlayed = c_datePlayed;
            playername = c_playername;
        }

        public int GetScoreId()
        {
            return scoreId;
        }

        public TimeSpan GetScore()
        {
            return score;
        }

        public DateTime GetDatePlayed()
        {
            return datePlayed;
        }

        public string GetPlayername()
        {
            return playername;
        }
    }
}
