using Microsoft.Toolkit.Uwp.Notifications;
using PotatoAlert.Deserialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoAlert
{
    internal class NotificationManager
    {
        public static void DisplayAlertNotification(Alert alert)
        {
            if (alert == null)
            {
                return;
            }
            new ToastContentBuilder()
                .AddText("PotatoAlert")
                .AddText("A new Gift of the Lotus alert is available!")
                .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 6 (or later), then your TFM must be net6.0-windows10.0.17763.0 or greater
        }
    }
}
