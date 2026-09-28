using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace score
{
    internal class Databasehandler
    {
        string connectionstring = "Server=localhost;Port=3306;Database=c#test;Uid=root;Pwd=;";
        DataTable dataTable = null;
        int maxScore = 10;
        Score score = null;
        List<Score> scorelist = null;
        int scoreId = 0;
        TimeSpan scoreTime = TimeSpan.Zero;
        DateTime scoreDate = DateTime.MinValue;
        string playername = string.Empty;
        int scorelistCount = 0;

        public void SetOrCreateNewUsername(string username)
        {
            FillDatatable("SELECT Playername FROM playertable WHERE Playername = '" + username + "'");

            if (dataTable.Rows.Count == 0)
            {
                ExecuteQuery("INSERT INTO playertable (Playername, AccountCreatedDate) VALUES ('" + username + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            }
        }

        public void AddNewScore(TimeSpan score, string playername)
        {
            ExecuteQuery("INSERT INTO scoretable (Testscore, TestDateTime, Playername) VALUES ('" + score + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + playername + "')");
        }

        public void ShowHighscore (ListBox updateListbox)
        {
            updateListbox.Items.Clear();
            scorelist = new List<Score>();
            FillDatatable("SELECT * FROM scoretable");
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (dataTable.Rows[i][0] != null)
                    {
                        scoreId = i;
                        scoreTime = (TimeSpan)dataTable.Rows[i][1];
                        scoreDate = (DateTime)dataTable.Rows[i][2];
                        playername = Convert.ToString(dataTable.Rows[i][3]);
                        score = new Score(scoreId, scoreTime, scoreDate, playername);
                        scorelist.Add(score);
                    }
                }
            }

            scorelist = scorelist.OrderBy(o => o.GetScore()).ThenBy(o => o.GetDatePlayed()).ToList();
            scorelistCount = scorelist.Count;

            if (scorelistCount > 10)
            {
                scorelistCount = 10;
            }
            for (int i = 0; i < scorelistCount; i++)
            {
                TimeSpan score = scorelist[i].GetScore();
                updateListbox.Items.Add("Number: " + (i + 1));
                updateListbox.Items.Add("Player: " + scorelist[i].GetPlayername());
                updateListbox.Items.Add(
                    "Score: " +
                    score.Seconds + "." +
                    score.Milliseconds.ToString("000") +
                    " seconds"
                );
                updateListbox.Items.Add("Date played: " + scorelist[i].GetDatePlayed());
                updateListbox.Items.Add("");
            }
        }

        public void FillDatatable(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();

                dataTable = new DataTable();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }
        }

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn)) 
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
