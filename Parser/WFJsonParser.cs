using System.Text.Json;
using System.Text.Json.Nodes;
using PotatoAlert.Deserialize;

namespace PotatoAlert.Parser;

internal class WFJsonParser
{
    public static void GetAlerts(string content)
    {
        var worldState = JsonNode.Parse(content);
        var jsonAlerts = worldState!["Alerts"]!;
        //Console.WriteLine(jsonAlerts);

        var alerts = JsonSerializer.Deserialize<List<Alert>>(jsonAlerts);

        if (alerts != null)
        {
            if (alerts.Count > 0)
                foreach (var alert in alerts)
                {
                    Console.WriteLine(alert.Tag);
                }
            else
            {
                Console.WriteLine("No active alerts found.");
            }
        }
        else
        {
            Console.WriteLine("Alerts is null!");
        }
    }
}