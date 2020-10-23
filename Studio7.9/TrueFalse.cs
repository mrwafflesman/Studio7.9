using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7._9
{
    class TrueFalse : Question
    {
        public string TFquestion;
        public string TFanswer;
        public string TFUserAnswer;
        public bool IsCorrect = false;

        public TrueFalse(string question, string answer) : base(question, answer)
        {
            TFquestion = question;
            TFanswer = answer;
        }

        public override bool DoQuestion()
        {
            Console.WriteLine(TFquestion);

            Console.WriteLine("\nEnter true or false:\n");

            TFUserAnswer = Console.ReadLine().ToLower();

            if (TFanswer == TFUserAnswer)
            {
                Console.WriteLine("Correct!");
                IsCorrect = true;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            return IsCorrect;
        }

    }
}

