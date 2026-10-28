using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eindproject
{
    internal class Question
    {
        int questionId = -1;
        string question = "";
        string rightAnswer = "";
        List<string> answers = new List<string>();

        public Question(int c_questionId, string c_question,
            string c_rightAnswer, string c_wrongAnswer1,
            string c_wrongAnswer2, string c_wrongAnswer3)
        {
            questionId = c_questionId;
            question = c_question;
            rightAnswer = c_rightAnswer;

            answers.Add(c_rightAnswer);
            answers.Add(c_wrongAnswer1);
            answers.Add(c_wrongAnswer2);
            answers.Add(c_wrongAnswer3);

            ShuffleAnswers();
        }

        public int GetQuestionId()
        {
            return questionId;
        }

        public string GetQuestion()
        {
            return question;
        }

        public string GetAnswer()
        {
            return rightAnswer;
        }

        public List<string> GetAnswers()
        {
            ShuffleAnswers();
            return answers;
        }

        private void ShuffleAnswers()
        {
            Random rng = new Random();

            for (int i = answers.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                string temp = answers[i];
                answers[i] = answers[j];
                answers[j] = temp;
            }
        }
    }
}
