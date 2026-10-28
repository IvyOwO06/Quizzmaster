using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindproject
{
    internal class QuestionHandler
    {
        DatabaseHandler databaseHandler = null;
        Random rng = null;
        DataTable dataTable = null;

        public void AddQuestion(string question, int category, string rightAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        {
            databaseHandler = new DatabaseHandler();

            string query = "INSERT INTO questions (question, categoryId, rightAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3) VALUES ('" + question + "', '" + category + "', '" + rightAnswer + "', '" + wrongAnswer1 + "', '" + wrongAnswer2 + "', '" + wrongAnswer3 + "')";

            databaseHandler.ExecuteQuery(query);
        }

        public void EditQuestion(int questionId, string question, int category,
            string rightAnswer, string wrongAnswer1,
            string wrongAnswer2, string wrongAnswer3)
        {
            databaseHandler = new DatabaseHandler();

            string query = "UPDATE questions SET question = '" + question +
                "', categoryId = " + category +
                ", rightAnswer = '" + rightAnswer +
                "', wrongAnswer1 = '" + wrongAnswer1 +
                "', wrongAnswer2 = '" + wrongAnswer2 +
                "', wrongAnswer3 = '" + wrongAnswer3 +
                "' WHERE questionId = " + questionId;

            databaseHandler.ExecuteQuery(query);
        }

        public DataTable GetQuestion(int questionId)
        {
            databaseHandler = new DatabaseHandler();

            string query = "SELECT * FROM questions WHERE questionId = " + questionId;

            return databaseHandler.FillDataGridView(query);
        }

        public void GetQuestionsFromDatabase(int category)
        {
            databaseHandler = new DatabaseHandler();
            if (category >= 3)
            {
                string query = "SELECT * FROM questions";
                databaseHandler.FillDataTable(query);
            }
            else
            {
                string query = "SELECT * FROM questions WHERE categoryId = '" + category + "'";
                databaseHandler.FillDataTable(query);
            }
        }

        public DataTable GetQuestions()
        {
            dataTable = databaseHandler.GetDataTable();
            return dataTable;
        }
    }
}
