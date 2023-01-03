using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace PotatoAlert
{
    internal class Program
    {
        private const string WFWorldStateURL_PC = "https://content.warframe.com/dynamic/worldState.php";

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("PotatoAlert");

            var jsonResponse = await FetchWFWorldState();
            Console.WriteLine(jsonResponse);
            WFJsonParser.GetAlerts(jsonResponse);
            NotificationManager.DisplayAlertNotification(new Deserialize.Alert());
        }

        private static async Task<string> FetchWFWorldState()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync(
                    WFWorldStateURL_PC);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}