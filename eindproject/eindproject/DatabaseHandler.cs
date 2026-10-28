using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt;

namespace eindproject
{
    internal class DatabaseHandler
    {
        string connectionString = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=;";
        DataTable dataTable = null;
        int row = 0;
        List<Score> scoreList = null;
        Score score = null;

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("Quiz"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void FillDataTable(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("Quizmaster"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
            }
        }

        public DataTable GetDataTable()
        {
            return dataTable;
        }

        public DataTable FillDataGridView(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public void ShowHighscore(ListBox updateListBox)
        {
            updateListBox.Items.Clear();
            scoreList = new List<Score>();
            FillDataTable("SELECT * FROM score");
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    int scoreId = i;
                    string username = Convert.ToString(dataTable.Rows[i][2]);
                    int scoreValue = Convert.ToInt32(dataTable.Rows[i][3]);
                    score = new Score(scoreId, scoreValue, username);
                    scoreList.Add(score);
                }
            }
            scoreList = scoreList.OrderByDescending(o => o.GetScore()).ToList();
            int scoreListCount = scoreList.Count;

            if (scoreListCount > 10)
            {
                scoreListCount = 10;
            }
            for (int i = 0; i < scoreListCount; i++)
            {
                updateListBox.Items.Add("Number: " + (i + 1));
                updateListBox.Items.Add("Player: " + scoreList[i].GetUsername());
                updateListBox.Items.Add("Score: " + scoreList[i].GetScore());
                updateListBox.Items.Add("");
            }
        }
    }
}
