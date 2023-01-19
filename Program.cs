using System.Net;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using PotatoAlert.Notifications;
using PotatoAlert.Parser;
using PotatoAlert.URL;

namespace PotatoAlert
{
    internal class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("PotatoAlert");

            var jsonResponse = await FetchWFWorldState();
            WFJsonParser.GetAlerts(jsonResponse);
            
            // dummy alert
            NotificationManager.DisplayAlertNotification(new Deserialize.Alert());
        }

        private static async Task<string> FetchWFWorldState()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                await client.GetAsync(
                    GetWFURL.GetWorldStateURL(GetWFURL.Platform.PC));
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}