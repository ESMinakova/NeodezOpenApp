using System.Net.Mail;

namespace NeodezMobApp.Views;

public partial class EmailPage : ContentPage
{
	public EmailPage()
	{
		InitializeComponent();
	}

    void btnSend_Clicked(object sender, System.EventArgs e)
    {
        var accessType = Connectivity.Current.NetworkAccess;
        if (accessType != NetworkAccess.Internet)        
            DisplayAlert("Ошибка", "Отсутствует соединение с интернетом", "ОK");        
        else
        {
            EmailManager.SendEmail(txtSubject.Text, txtBody.Text);
            Shell.Current.Navigation.PopAsync();
        }
    }
}