using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindproject
{
    internal class Score
    {
        int scoreId = int.MinValue;
        int score = 0;
        string username = string.Empty;

        public Score(int c_scoreId, int c_score, string c_username)
        {
            scoreId = c_scoreId;
            score = c_score;
            username = c_username;
        }

        public int GetScoreId()
        {
            return scoreId;
        }

        public int GetScore()
        {
            return score;
        }

        public string GetUsername()
        {
            return username;
        }
    }
}
