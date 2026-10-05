using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemodes
{
    internal class Question
    {
        int questionId = -1;
        string question = "";
        string answer = "";

        public Question(int c_questionId, string c_question, string c_answer)
        {
            questionId = c_questionId;
            question = c_question;
            answer = c_answer;
        }

        public string GetQuestion()
        {
            return question;
        }

        public string GetAnswer()
        {
            return answer;
        }
    }
}
