using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;
using System.Collections;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Trivia
    {
        public int responce_code;
        public List<TriviaResult> results;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());

            s = reader.ReadToEnd();

            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; i++)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{trivia.results[0].question}?");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            var answers = new List<string>();
            string correct_answer = trivia.results[0].correct_answer;
            answers.Add(correct_answer);
            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; i++)
            {
                answers.Add(trivia.results[0].incorrect_answers[i]);
            }

            var rnd = new Random();
            var randomizedAnswers = answers.OrderBy(item => rnd.Next()).ToList();

            for (int i = 0; i < randomizedAnswers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {randomizedAnswers[i]}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Enter a number for your answer [1-{randomizedAnswers.Count}]:");

            int user_answer;
            int.TryParse(Console.ReadLine(), out user_answer);

            while (user_answer > randomizedAnswers.Count || user_answer == 0)
            {
                Console.WriteLine($"Please enter a correnct number for your answer [1-{randomizedAnswers.Count}]:");
                int.TryParse(Console.ReadLine(), out user_answer);
            }
            Console.WriteLine();
            if (randomizedAnswers[user_answer-1] == correct_answer)
            {
                Console.ForegroundColor =  ConsoleColor.Green;
                Console.WriteLine("Congrats, your answer is correct!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                int answer_no = randomizedAnswers.IndexOf(correct_answer);
                Console.WriteLine($"Sorry, your answer is incorrect.");
                Console.WriteLine($"Correct answer is: \n\t{answer_no+1}. {correct_answer}");
            }
            Console.WriteLine();
        }
    }
}
