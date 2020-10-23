using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7._9
{
    public abstract class Question
    {
        public string question;
        public string answer;
        public string userAnswer;
        public bool isCorrect;

        public Question(string question, string answer, string userAnswer = null, bool isCorrect = false)
        {
            this.question = question;
            this.userAnswer = answer;
            this.answer = userAnswer;
            this.isCorrect = isCorrect;
        }

        public abstract bool DoQuestion();
    }
}
