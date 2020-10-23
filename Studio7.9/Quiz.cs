using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7._9
{
    class Quiz
    {
        List<Question> quiz = new List<Question>();

        Question baseMC = new MultipleChoice("What is 2+2?:, [1] - 5, [2] - 9, [3] - 4, [4] - 1", "3");
        Question baseTF = new TrueFalse("The Earth is flat.", "false");
        Question baseCB = new Checkbox("Select all that are numbers:, [1] - 19, [2] - d, [3] - 4, [4] - z", "1, 3");

        public Quiz()
        {

        }

        public void AddBaseQuestions()
        {
            quiz.Add(baseMC);
            quiz.Add(baseTF);
            quiz.Add(baseCB);
        }

        public void AddQuestions()
        {
            int input;
            Console.WriteLine("What type of question would you like to add?\n[1] - Multiple Choice\n[2] - True or False\n[3] - Checkbox");

            input = int.Parse(Console.ReadLine());

            do
            {
                if (input == 1)
                {
                    string question;
                    string answer;

                    Console.WriteLine("Enter the question followed by the possible answers with their respective numbers, separated by commas, then hit enter. Enter the number of the correct answer.");
                    question = Console.ReadLine();
                    answer = Console.ReadLine();

                    Question newMC = new MultipleChoice(question, answer);
                    quiz.Add(newMC);
                }
                else if (input == 2)
                {
                    string question;
                    string answer;

                    Console.WriteLine("Enter the question. Enter wether the answer is true or false.");
                    question = Console.ReadLine();
                    answer = Console.ReadLine();

                    Question newTF = new TrueFalse(question, answer);
                    quiz.Add(newTF);
                }
                else if(input == 3)
                {
                    string question;
                    string answer;

                    Console.WriteLine("Enter the question followed by the possible answers with their respective numbers, separated by commas, then hit enter. Enter the numbers of the correct answers, separated by commas.");
                    question = Console.ReadLine();
                    answer = Console.ReadLine();

                    Question newCB = new Checkbox(question, answer);
                    quiz.Add(newCB);
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter a valid input:");
                    input = int.Parse(Console.ReadLine());
                }
            } while (input != 1 && input != 2 && input != 3);
        }

        public void TakeQuiz()
        {
            while(true)
            {
                int input;

                Console.WriteLine("What would you like to do?\n[1] - Add questions to quiz\n[2] - Take the quiz");

                input = int.Parse(Console.ReadLine());

                do
                {
                    int numCorrect = 0;

                    if (input == 1)
                    {
                        AddQuestions();
                    }
                    else if (input == 2)
                    {
                        foreach(Question question in quiz)
                        {
                            bool correct = question.DoQuestion();
                            
                            if (correct)
                            {
                                numCorrect++;
                            }
                        }

                        Console.WriteLine("\nYou got " + numCorrect + " correct out of " + quiz.Count + " possible.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a valid input:");
                        input = int.Parse(Console.ReadLine());
                    }
                } while (input != 1 && input != 2);
            }  
            
        }
    }
}
