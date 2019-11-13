using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TriviaAPIConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Retriving trivia question....");

            TriviaClient trivia = new TriviaClient();
            TriviaResponse result = await trivia.GetTriviaQuestionsAsync(3);
            DisplayQuestions(result.Results); ;

           
        }

        static void DisplayQuestions(List<Result> questions)
        {
            for (int i = 0; i < questions.Count; i++)
            { 
                Console.WriteLine($"{q}")
                Console.WriteLine($"Let me ask: {questions[i].Question}\n");
                Console.ReadKey();
                Console.WriteLine($"{questions[i].Correct_answer}\n");
                
            }
        }
    }
}
