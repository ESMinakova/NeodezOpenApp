using NeodezMobApp.ViewModels;
using System.Collections.ObjectModel;
using System.Text;

namespace NeodezMobApp.Views;

public partial class DryCleaningOrderPage : ContentPage
{
    public DryCleaningOrderPage()
	{
		InitializeComponent();
    }

    private async Task<OrderWithDescriptionViewModel> CreateNewOrder()
    {
        var text = await order.ToOrderDescriptionAsync();
        var currentOrder = new OrderWithDescriptionViewModel()
        {
            Id = new Guid(),
            OrderTime = DateTime.Now,
            Category = CategoryViewModel.DryCleaning,

            Description = $"Что надо почистить - {dryCleaningSubjectEntry.Text} \n" +
            $"{text}"
        };

        return currentOrder;
    }

    private async void OrderButton_Clicked(object sender, EventArgs e)
    {
        var newOrder = new OrderWithDescriptionViewModel();
        newOrder = await CreateNewOrder();
        var newOrderMesaageText = CreateNewMessageText(newOrder);

        var accessType = Connectivity.Current.NetworkAccess;
        if (accessType != NetworkAccess.Internet)
            await DisplayAlert("Ошибка", "Отсутствует соединение с интернетом", "ОK");
        else
        {
            EmailManager.SendEmail("Новый заказ из приложения. Химчистка", newOrderMesaageText);
            await Shell.Current.Navigation.PopAsync();
        }
    }

    private string CreateNewMessageText(OrderWithDescriptionViewModel newOrder)
    {
        var tempStringBuilder = new StringBuilder();
        tempStringBuilder.Append(newOrder.Category + " \n" + newOrder.OrderTime.ToString() + " \n" + newOrder.Description);

        return tempStringBuilder.ToString();
    }
}