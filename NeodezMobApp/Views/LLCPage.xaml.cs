using NeodezMobApp.ViewModels;

namespace NeodezMobApp.Views;

public partial class LLCPage : ContentPage
{
	public LLCPage()
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