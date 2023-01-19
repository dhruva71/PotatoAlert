using Microsoft.Toolkit.Uwp.Notifications;
using PotatoAlert.Deserialize;

namespace PotatoAlert.Notifications
{
    internal static class NotificationManager
    {
        public static void DisplayAlertNotification(Alert? alert)
        {
            if (alert == null)
            {
                return;
            }
            new ToastContentBuilder()
                .AddText("PotatoAlert")
                .AddText("A new Gift of the Lotus alert is available!")
                .Show();
        }
    }
}
