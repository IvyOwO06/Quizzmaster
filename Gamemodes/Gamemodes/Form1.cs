using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gamemodes
{
    public partial class Form1 : Form
    {
        int gameTime = 60;
        int currentTime = 0;

        string connectionstring = "Server=localhost;Port=3306;Database=c#test;Uid=root;Pwd=;";
        DataTable dataTable = null;
        int row = 0;

        Question question = null;
        List<Question> questionList = new List<Question>();
        Random random = new Random();
        int currentQuestion = 0;
        bool questionAnswered = false;
        string answer = "";

        string currentMode = "";
        string answerLeft, answerRight = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblQuestion.MaximumSize = new Size(300, 0);
            lblQuestion.AutoSize = true;

            btnYes.Enabled = false;
            btnNo.Enabled = false;
            GetAllQuestions();
            random = new Random();
        }

        private void btnTimeLimitMode_Click(object sender, EventArgs e)
        {
            currentTime = gameTime;
            currentMode = "TimeLimit";
            btnYes.Text = "Yes";
            btnNo.Text = "No";
            StartQuiz();
        }

        private void btnRandomMode_Click(object sender, EventArgs e)
        {
            currentTime = 0;
            currentMode = "Random";
            RandomButtonAnswers();
            StartQuiz();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (questionAnswered)
            {
                if (answer != questionList[currentQuestion].GetAnswer())
                {
                    lblQuestion.Text = "False! your score:" + currentQuestion;
                    btnYes.Enabled = false;
                    btnNo.Enabled = false;
                    btnTimeLimitMode.Enabled = true;
                    btnRandomMode.Enabled = true;
                    tmrGame.Stop();
                }
                else
                {
                    currentQuestion++;
                    lblQuestion.Text = questionList[currentQuestion].GetQuestion();
                }
                questionAnswered = false;
            }
            if (currentMode == "TimeLimit")
            {
                currentTime--;
            }
            else
            {
                currentTime++;
            }
            lblTimer.Text = currentTime.ToString();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (currentMode == "TimeLimit")
            {
                answer = "Yes";
            }
            else
            {
                answer = answerLeft;
                RandomButtonAnswers();
            }
            questionAnswered = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (currentMode == "TimeLimit")
            {
                answer = "No";
            }
            else
            {
                answer = answerRight;
                RandomButtonAnswers();
            }
            questionAnswered = true;
        }

        private void GetAllQuestions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM questiontable", conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow rows in dataTable.Rows)
                        {
                            question = new Question(
                                Convert.ToInt32(rows[0]),
                                rows[1].ToString(),
                                rows[2].ToString()
                            );

                            questionList.Add(question);
                            row++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No items found, add new items to fill the list.");
                    }
                }
            }
        }

        private void ShuffleList()
        {
            for (int i = questionList.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Question temp = questionList[i];
                questionList[i] = questionList[j];
                questionList[j] = temp;
            }
        }

        private void StartQuiz()
        {
            btnYes.Enabled = true;
            btnNo.Enabled = true;
            btnTimeLimitMode.Enabled = false;
            btnRandomMode.Enabled = false;
            lblTimer.Text = currentTime.ToString();
            ShuffleList();
            currentQuestion = 0;
            lblQuestion.Text = questionList[currentQuestion].GetQuestion();
            tmrGame.Start();
        }

        private void RandomButtonAnswers()
        {
            if (random.Next(101) < 51)
            {
                answerLeft = "Yes";
                answerRight = "No";
            }
            else
            {
                answerLeft = "No";
                answerRight = "Yes";
            }
            btnYes.Text = answerLeft;
            btnNo.Text = answerRight;
        }
    }
}
