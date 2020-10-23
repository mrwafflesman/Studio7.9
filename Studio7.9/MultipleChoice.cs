using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7._9
{
    class MultipleChoice : Question
    {
        public string MCquestion;
        public string MCanswer;
        public string MCUserAnswer;
        public bool IsCorrect = false;

        public MultipleChoice(string question, string answer) : base(question, answer)
        {
            MCquestion = question;
            MCanswer = answer;
        }

        public override bool DoQuestion()
        {
            string[] q = MCquestion.Split(", ");
            foreach(string item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nEnter the number of the correct answer:\n");

            MCUserAnswer = Console.ReadLine();

            if(MCanswer == MCUserAnswer)
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
