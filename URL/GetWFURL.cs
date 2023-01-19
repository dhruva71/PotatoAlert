namespace PotatoAlert.URL;

public class GetWFURL
{
    public enum Platform
    {
        PC,
        PlayStation,
        Xbox,
        Switch,
    }

    public static string GetWorldStateURL(Platform platform)
    {
        string worldStateUrl;
        switch (platform)
        {
            case Platform.PC:
                worldStateUrl = "https://content.warframe.com/dynamic/worldState.php";
                break;
            case Platform.PlayStation:
                worldStateUrl = "https://content-ps4.warframe.com/dynamic/worldState.php";
                break;
            case Platform.Xbox:
                worldStateUrl = "https://content-xb1.warframe.com/dynamic/worldState.php";
                break;
            case Platform.Switch:
                worldStateUrl = "https://content-swi.warframe.com/dynamic/worldState.php";
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
        }

        return worldStateUrl;
    }
}