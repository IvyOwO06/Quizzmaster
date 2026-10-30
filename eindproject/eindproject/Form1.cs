using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eindproject
{
    public partial class Form1 : Form
    {
        Auth auth = null;
        DatabaseHandler databaseHandler = null;
        QuestionHandler questionHandler = null;
        Random rng = null;
        List<Question> questionList = new List<Question>();
        Question questions = null;
        private AudioManager audioManager = new AudioManager();

        string username = "";
        string password = "";
        string cpassword = "";
        int isAdmin = 0;
        bool isEditing = false;
        int editingQuestionId = 0;
        bool choosingCategory = true;
        int row = 0;
        int currentQuestionIndex = 0;
        int score = 0;
        int stopwatch = 60;
        int stopwatchQuestions = 5;
        int userId = 0;
        bool canChangeTab = true;

        public Form1()
        {
            InitializeComponent();

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rng = new Random();
            databaseHandler = new DatabaseHandler();
            tabControl.TabPages.Remove(tbpAdmin);
            tabControl.TabPages.Remove(tbpQuiz);
            tabControl.TabPages.Remove(tbpRegister);
            ResizeFormToFit(tbpLogin);

            dgvQuestions.DataSource = databaseHandler.FillDataGridView("SELECT * FROM questions");
            dgvAccounts.DataSource = databaseHandler.FillDataGridView("SELECT username, isAdmin FROM users");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbxLoginUsername.Text;
            password = tbxLoginPassword.Text;

            auth = new Auth();

            bool success = auth.Login(username, password);

            if (success)
            {
                User loggedInUser = auth.GetLoggedInUser();

                username = loggedInUser.GetUsername();
                userId = loggedInUser.GetUserId();

                bool isAdmin = loggedInUser.GetIsAdmin();

                MessageBox.Show("Welcome " + username + "!");

                tabControl.TabPages.Remove(tbpLogin);
                tabControl.TabPages.Add(tbpQuiz);
                ResizeFormToFit(tbpQuiz);
                this.Width = btnAnswerBottomRight.Right + 40;

                if (isAdmin)
                {
                    tabControl.TabPages.Add(tbpAdmin);
                }
            }
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpLogin);
            tabControl.TabPages.Add(tbpRegister);
            ResizeFormToFit(tbpRegister);
        }

        private void ResizeFormToFit(TabPage page)
        {
            if (page == null)
                return;

            int right = 0;
            int bottom = 0;

            foreach (Control control in page.Controls)
            {
                right = Math.Max(right, control.Right);
                bottom = Math.Max(bottom, control.Bottom);
            }

            int padding = 20;

            // Resize the TabControl to fit the page contents
            tabControl.Width = right + padding;
            tabControl.Height = bottom + padding + 20;

            // Resize the form to fit the TabControl
            this.ClientSize = new Size(
                tabControl.Right,
                tabControl.Bottom
            );
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tbpAdmin)
            {
                ResizeFormToFit(tabControl.SelectedTab);
            } 
            else if (tabControl.SelectedTab == tbpQuiz)
            {
                ResizeFormToFit(tabControl.SelectedTab);
                this.Width = btnAnswerBottomRight.Right + 40;
                lbxHighscore.Visible = false;
                cbxShowHighscore.Checked = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            username = tbxRegisterUsername.Text;
            password = tbxRegisterPassword.Text;
            cpassword = tbxRegisterCPassword.Text;

            auth = new Auth();
            bool success = auth.Register(username, password, cpassword, 0);

            if (success)
            {
                tabControl.TabPages.Remove(tbpRegister);
                tabControl.TabPages.Add(tbpLogin);
                ResizeFormToFit(tbpLogin);
            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpRegister);
            tabControl.TabPages.Add(tbpLogin);
            ResizeFormToFit(tbpLogin);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpLogin);
            tabControl.TabPages.Add(tbpQuiz);
            tabControl.TabPages.Add(tbpAdmin);
            ResizeFormToFit(tbpQuiz);
            this.Width = btnAnswerBottomRight.Right + 40;
        }

        private void btnAdminAddAccount_Click(object sender, EventArgs e)
        {
            auth = new Auth();
            username = tbxAdminUsername.Text;
            password = tbxAdminPassword.Text;
            cpassword = tbxAdminCPassword.Text;
            if (cbxIsAdmin.Checked) 
            { 
                isAdmin = 1;
            }
            auth.Register(username, password, cpassword, isAdmin);
            dgvAccounts.DataSource = databaseHandler.FillDataGridView("SELECT username, isAdmin FROM users");
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an account to remove.");
                return;
            }

            string username = dgvAccounts.SelectedRows[0].Cells["username"].Value.ToString();
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove " + username + "?",
                "Confirm removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                databaseHandler = new DatabaseHandler();

                string query = "DELETE FROM users WHERE username = '" + username + "'";

                databaseHandler.ExecuteQuery(query);

                MessageBox.Show("Account removed successfully.", "Success");

                dgvAccounts.DataSource = databaseHandler.FillDataGridView("SELECT username, isAdmin FROM users");
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                questionHandler = new QuestionHandler();

                string question = tbxQuestion.Text;
                int category = rbtnDeltarune.Checked ? 1 : 2;
                string rightAnswer = tbxRightAnswer.Text;
                string wrongAnswer1 = tbxWrongAnswer1.Text;
                string wrongAnswer2 = tbxWrongAnswer2.Text;
                string wrongAnswer3 = tbxWrongAnswer3.Text;

                questionHandler.EditQuestion(
                    editingQuestionId,
                    question,
                    category,
                    rightAnswer,
                    wrongAnswer1,
                    wrongAnswer2,
                    wrongAnswer3
                );

                tbxQuestion.Text = "";
                rbtnDeltarune.Checked = true;
                tbxRightAnswer.Text = "";
                tbxWrongAnswer1.Text = "";
                tbxWrongAnswer2.Text = "";
                tbxWrongAnswer3.Text = "";

                isEditing = false;
                editingQuestionId = 0;

                MessageBox.Show("Question edited successfully", "Success");

                dgvQuestions.DataSource = databaseHandler.FillDataGridView("SELECT * FROM questions");
                btnAddQuestion.Text = "Add";
            }
            else
            {
                questionHandler = new QuestionHandler();
                string question = tbxQuestion.Text;
                int category = rbtnDeltarune.Checked ? 1 : 2;
                string rightAnswer = tbxRightAnswer.Text;
                string wrongAnswer1 = tbxWrongAnswer1.Text;
                string wrongAnswer2 = tbxWrongAnswer2.Text;
                string wrongAnswer3 = tbxWrongAnswer3.Text;
                questionHandler.AddQuestion(question, category, rightAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
                tbxQuestion.Text = "";
                rbtnDeltarune.Checked = true;
                tbxRightAnswer.Text = "";
                tbxWrongAnswer1.Text = "";
                tbxWrongAnswer2.Text = "";
                tbxWrongAnswer3.Text = "";
                MessageBox.Show("Question added successfully", "Success");
                dgvQuestions.DataSource = databaseHandler.FillDataGridView("SELECT * FROM questions");
            }
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a question to remove.");
                return;
            }

            string question = dgvQuestions.SelectedRows[0].Cells["question"].Value.ToString();
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove " + question + "?",
                "Confirm removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                databaseHandler = new DatabaseHandler();

                string query = "DELETE FROM questions WHERE question = '" + question + "'";

                databaseHandler.ExecuteQuery(query);

                MessageBox.Show("Question removed successfully.", "Success");

                dgvQuestions.DataSource = databaseHandler.FillDataGridView("SELECT * FROM questions");
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow != null)
            {
                int questionId = Convert.ToInt32(
                    dgvQuestions.CurrentRow.Cells["questionId"].Value
                );

                LoadQuestion(questionId);
            }
        }

        private void LoadQuestion(int questionId)
        {
            questionHandler = new QuestionHandler();

            DataTable dataTable = questionHandler.GetQuestion(questionId);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                editingQuestionId = questionId;

                tbxQuestion.Text = row["question"].ToString();

                int category = Convert.ToInt32(row["categoryId"]);

                rbtnDeltarune.Checked = category == 1;
                rbtnUndertale.Checked = category == 2;

                tbxRightAnswer.Text = row["rightAnswer"].ToString();
                tbxWrongAnswer1.Text = row["wrongAnswer1"].ToString();
                tbxWrongAnswer2.Text = row["wrongAnswer2"].ToString();
                tbxWrongAnswer3.Text = row["wrongAnswer3"].ToString();

                isEditing = true;

                btnAddQuestion.Text = "Save";
            }
        }

        private void btnAnswerTopLeft_Click(object sender, EventArgs e)
        {
            if (choosingCategory)
            {
                //deltarune
                StartGame(1);
            }
            else
            {
                if (btnAnswerTopLeft.Text == questionList[currentQuestionIndex].GetAnswer())
                {
                    Correct();
                }
                else
                {
                    Wrong();
                }
                NextQuestion();
            }
        }
        private void btnAnswerTopRight_Click(object sender, EventArgs e)
        {
            if (choosingCategory)
            {
                //undertale
                StartGame(2);
            }
            else
            {
                if (btnAnswerTopRight.Text == questionList[currentQuestionIndex].GetAnswer())
                {
                    Correct();
                }
                else
                {
                    Wrong();
                }
                NextQuestion();
            }
        }

        private void btnAnswerBottomLeft_Click(object sender, EventArgs e)
        {
            if (choosingCategory)
            {
                //general
                StartGame(3);
            }
            else
            {
                if (btnAnswerBottomLeft.Text == questionList[currentQuestionIndex].GetAnswer())
                {
                    Correct();
                }
                else
                {
                    Wrong();
                }
                NextQuestion();
            }
        }


        private void btnAnswerBottomRight_Click(object sender, EventArgs e)
        {
            if (btnAnswerBottomRight.Text == questionList[currentQuestionIndex].GetAnswer())
            {
                Correct();
            }
            else
            {
                Wrong();
            }
            NextQuestion();
        }

        private void StartGame(int category) //name may change later
        {
            choosingCategory = false;
            
            questionHandler = new QuestionHandler();
            questionHandler.GetQuestionsFromDatabase(category);
            DataTable allQuestions = questionHandler.GetQuestions();
            foreach (DataRow rows in allQuestions.Rows)
            {
                questions = new Question(
                    Convert.ToInt32(rows[0]),
                    rows[1].ToString(),
                    rows[2].ToString(),
                    rows[3].ToString(),
                    rows[4].ToString(),
                    rows[5].ToString()
                    );

                questionList.Add(questions);
                row++;
            }
            ShuffleQuestions();

            NextQuestion();
            btnAnswerBottomRight.Visible = true;
            btnSkip.Visible = true;
            btnSkip.Enabled = true;
            tmrQuiz.Start();
            cbxShowHighscore.Enabled = false;
            canChangeTab = false;

            audioManager.PlayMusic("QUIZ.wav");

        }

        private void ShuffleQuestions()
        {
            for (int i = questionList.Count -1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                Question temp = questionList[i];
                questionList[i] = questionList[j];
                questionList[j] = temp;
            }
        }

        private void NextQuestion()
        {
            stopwatchQuestions = 5;
            currentQuestionIndex++;
            lblScore.Text = score.ToString();

            if (currentQuestionIndex >= questionList.Count)
            {
                tmrQuiz.Stop();
                StopQuiz();
                MessageBox.Show("Quiz Finished!");
                return;
            }

            lblQuestion.Text = questionList[currentQuestionIndex].GetQuestion();

            List<string> answers = questionList[currentQuestionIndex].GetAnswers();

            btnAnswerTopLeft.Text = answers[0];
            btnAnswerTopRight.Text = answers[1];
            btnAnswerBottomLeft.Text = answers[2];
            btnAnswerBottomRight.Text = answers[3];
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            btnSkip.Enabled = false;
            NextQuestion();
        }

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            stopwatch--;
            stopwatchQuestions--;
            if (stopwatch == 0)
            {
                lblTimer.Text = "0";
                tmrQuiz.Stop();
                StopQuiz();
                MessageBox.Show("Time's up!", "Loser");
                
                return;
            }
            if (stopwatch == 10)
            {
                this.BackColor = Color.Red;
                tbpQuiz.BackColor = Color.Red;
                audioManager.SetMusicSpeed(1.5);
            }
            if (stopwatchQuestions == 0)
            {
                NextQuestion();
            }
            lblQuestionTime.Text = stopwatchQuestions.ToString();
            lblTimer.Text = stopwatch.ToString();
        }

        private void StopQuiz()
        {
            databaseHandler = new DatabaseHandler();
            string query = "INSERT INTO score (score, userId, username) VALUES ('" + score + "' ,'" + userId + "', '" + username + "')";
            audioManager.StopMusic();
            databaseHandler.ExecuteQuery(query);
            score = 0;
            lblScore.Text = score.ToString();
            stopwatch = 60;
            stopwatchQuestions = 5;
            lblTimer.Text = stopwatch.ToString();
            lblQuestionTime.Text = stopwatchQuestions.ToString();
            choosingCategory = true;
            btnAnswerTopLeft.Text = "Deltarune";
            btnAnswerTopRight.Text = "Undertale";
            btnAnswerBottomLeft.Text = "General";
            lblQuestion.Text = "Welcome lightner, please choose a Category";
            this.BackColor = Color.LightGray;
            tbpQuiz.BackColor = Color.White;
            btnAnswerBottomRight.Visible = false;
            btnSkip.Visible = false;
            cbxShowHighscore.Enabled = true;
            canChangeTab = true;
        }

        private void cbxShowHighscore_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowHighscore.Checked)
            {
                lbxHighscore.Visible = true;
                databaseHandler.ShowHighscore(lbxHighscore);
                this.Width = lbxHighscore.Right + 40;
            }
            else
            {
                lbxHighscore.Visible = false;
                this.Width = btnAnswerBottomRight.Right + 40;
            }
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!canChangeTab)
            {
                e.Cancel = true;
            }
        }

        private void Correct()
        {
            score += 1000;
            Bitmap bm = new Bitmap(Properties.Resources.undertale_text_box_ralsei_correct);
            audioManager.PlaySound("ding.wav");
            pbxRalsei.Image = bm;
            lblAsterisk.Visible = true;
            lblWrongOrCorrect.Text = "Correct";
            lblWrongOrCorrect.Visible = true;
        }

        private void Wrong()
        {
            score -= 500;
            Bitmap bm = new Bitmap(Properties.Resources.undertale_text_box_ralsei_wrong);
            audioManager.PlaySound("buzzer.wav");
            pbxRalsei.Image = bm;
            lblAsterisk.Visible = true;
            lblWrongOrCorrect.Text = "WRONG";
            lblWrongOrCorrect.Visible = true;
        }
    }
}
