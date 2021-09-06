using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_01_APIChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            ArcGISRESTAPIService apiService = new ArcGISRESTAPIService();

            Result<SearchSuggestion> chicago = apiService.GetResultAsync<SearchSuggestion>("chicago").Result;
            foreach (SearchSuggestion suggestion in chicago.Suggestions)
            {
                //Console.WriteLine(suggestion);
                Console.WriteLine($"text: {suggestion.Text}\n" +
                    $"magicKey: {suggestion.MagicKey}\n" +
                    $"isCollection: {suggestion.IsCollection}");
            }

            Console.ReadKey();

        }
    }
}
