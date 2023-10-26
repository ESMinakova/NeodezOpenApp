using NeodezMobApp.Views;

namespace NeodezMobApp.ContentViews;

public partial class ConnectionButtonsContentView : ContentView
{
	public ConnectionButtonsContentView()
	{
		InitializeComponent();
	}

    public async void OnEmailButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new EmailPage());
    }

    public async void WhatsAppButtonClicked(object sender, EventArgs e)
    {
        await MessengeManager.TryLaunchWhatsAppAsync();
    }

    public async void TelegramButtonClicked(object sender, EventArgs e)
    {
        await MessengeManager.TryLaunchTelegramAsync();
    }
}