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
            string result = await trivia.GetTriviaQuestionsAsync();

            Console.WriteLine("Resceived trivia question");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
