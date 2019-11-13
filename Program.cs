using System;
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

            Console.WriteLine("Resceived trivia question");

            Console.WriteLine(result.Results[0].Question);

            Console.ReadKey();
        }
    }
}
