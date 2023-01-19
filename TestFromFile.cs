using System.Text.Json;
using PotatoAlert.Deserialize;
using PotatoAlert.Parser;

namespace PotatoAlert;

internal class TestFromFile
{
    private static void TestWFJsonFromFile()
    {
        var path = @"/warframe_world_state_pc.json";
        var warframeJsonFileInfo = new FileInfo(System.AppDomain.CurrentDomain.BaseDirectory + path);
        if (warframeJsonFileInfo.Exists)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Loading data from " + Path.GetFileName(path));
            Console.ResetColor();
            var content = File.ReadAllText(path);

            WFJsonParser.GetAlerts(content);
        }
        else
        {
            Console.WriteLine("Warframe json file not found!");
        }
    }

    private void TestAlertFromJsonString()
    {
        var jsonAlert = @"
            {
                ""_id"": {
                    ""$oid"": ""637d23e9b89a2480e0055f56""
                },
                ""Activation"": {
                    ""$date"": {
                        ""$numberLong"": ""1671217200000""
                            }
                },
                ""Expiry"": {
                    ""$date"": {
                        ""$numberLong"": ""1672513200000""
                            }
                },
                ""MissionInfo"": {
                    ""location"": ""SolNode25"",
                    ""missionType"": ""MT_TERRITORY"",
                    ""faction"": ""FC_CORPUS"",
                    ""difficulty"": 1,
                    ""missionReward"": {
                        ""credits"": 20000,
                        ""items"": [
                            "" / Lotus / StoreItems / Upgrades / Skins / Sigils / HolidaySigilXmas2014D""
                        ]
                    },
                    ""levelOverride"": "" / Lotus / Levels / Proc / Corpus / CorpusGasCityInterception"",
                    ""enemySpec"": "" / Lotus / Types / Game / EnemySpecs / CorpusGasRemasterDefenseSquad"",
                    ""minEnemyLevel"": 20,
                    ""maxEnemyLevel"": 30,
                    ""descText"": "" / Lotus / Language / Alerts / TennoUnitedAlert"",
                    ""maxWaveNum"": 2
                },
                ""Tag"": ""LotusGift"",
                ""ForceUnlock"": true
            }";
        var alert = JsonSerializer.Deserialize<PotatoAlert.Deserialize.Alert>(jsonAlert);
        if (alert != null)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (alert.Tag == "LotusGift")
            {
                //Assert.Pass();
                return;
            }
        }
        else
        {
            //Assert.Fail();
        }
    }
}