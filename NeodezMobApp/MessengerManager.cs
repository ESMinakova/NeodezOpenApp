
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NeodezMobApp
{
    public static class MessengeManager
    {
        public static async Task TryLaunchWhatsAppAsync()
        {
            var phoneNumber = "+7**********";            

            bool supportsUri = await Launcher.Default.CanOpenAsync($"whatsapp://send?phone=+{phoneNumber}");

            if (supportsUri)
                await Launcher.Default.OpenAsync($"whatsapp://send?phone=+{phoneNumber}&text=");

            else
                await App.Current.MainPage.DisplayAlert("Ошибка", "Невозможно запустить WhatsApp", "OK");
        }

        public static async Task TryLaunchTelegramAsync()
        {
            bool supportsUri = await Launcher.Default.CanOpenAsync($"tg://resolve?domain=*******");

            if (supportsUri)
                await Launcher.Default.OpenAsync($"tg://resolve?domain=********");

            else
                await App.Current.MainPage.DisplayAlert("Ошибка", "Невозможно запустить Telegram", "OK");
        }
    }
}
