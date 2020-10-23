using System;

namespace Studio7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            quiz.AddBaseQuestions();

            quiz.TakeQuiz();
        }
    }
}
