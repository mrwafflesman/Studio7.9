using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Studio7._9
{
    class Checkbox : Question
    {
        public string CBquestion;
        public string CBanswer;
        public string CBUserAnswer;
        public bool IsCorrect = false;

        public Checkbox(string question, string answer) : base(question, answer)
        {
            CBquestion = question;
            CBanswer = answer;
        }

        public override bool DoQuestion()
        {
            string[] q = CBquestion.Split(", ");
            foreach (string item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nEnter the numbers of all correct answers:\n");
            string input;
            
            do
            {
                input = Console.ReadLine().ToLower();
                if(!String.IsNullOrEmpty(input))
                {
                    if(String.IsNullOrEmpty(CBUserAnswer))
                    {
                        CBUserAnswer = input;
                    }
                    else
                    {
                        CBUserAnswer = CBUserAnswer + ", " + input;
                    }
                }
            } while (!String.IsNullOrEmpty(input));

            string[] userAns = CBUserAnswer.Split(", ");
            string[] ans = CBanswer.Split(", ");
            int userCount = 0;
            int ansCount = ans.Length;

            foreach(string item in userAns)
            {
                if (Array.Exists(ans, x => x == item))
                {
                    userCount++;
                }
            }

            if (userCount == ansCount && ansCount == userAns.Length)
            {
                Console.WriteLine("Correct!");
                IsCorrect = true;
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            CBUserAnswer = "";

            return IsCorrect;
        }
    }
}
