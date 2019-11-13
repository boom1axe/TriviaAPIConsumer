using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TriviaAPIConsumer
{
    public class TriviaClient
    {
        static readonly HttpClient client = new HttpClient();

        //Static constructor; runs once per class
        //https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netframework-4.8
        static TriviaClient()
        {
            //Initialize all HttpClient settings
            client.BaseAddress = new Uri("https://opentdb.com/");

        }

        public async Task<TriviaResponse> GetTriviaQuestionsAsync(byte numQuestions)
        {
            HttpResponseMessage response = 
                await client.GetAsync($"api.php?amount={numQuestions}");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                TriviaResponse result = JsonConvert.DeserializeObject<TriviaResponse>(data);


                return result;
            }
            else
            {
                //if not successful, null is returned
                return null;
            }
        }
    }

    public class Result
    {
        public string Category { get; set; }
        [JsonProperty("Type")]
        public string QuestionType { get; set; }
        public string Difficulty { get; set; }
        public string Question { get; set; }
        public string Correct_answer { get; set; }
        public List<string> Incorrect_answers { get; set; }
    }

    public class TriviaResponse
    {
        public int Response_code { get; set; }
        public List<Result> Results { get; set; }
    }

}
