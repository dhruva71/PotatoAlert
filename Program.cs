using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace PotatoAlert
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("PotatoAlert");

            var jsonResponse =  await FetchWFWorldState();
            Console.WriteLine(jsonResponse);
            WFJsonParser.GetAlerts(jsonResponse);
        }

        private static async Task<string> FetchWFWorldState()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync(
                    "https://content.warframe.com/dynamic/worldState.php");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}