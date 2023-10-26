using NeodezMobApp.ViewModels;
using NeodezMobApp.ViewModels.Helpers;
using System.Collections.ObjectModel;
using System.Text;

namespace NeodezMobApp.Views;

public partial class DesinsectionOrderPage : ContentPage
{	
    public DesinsectionOrderPage()
    {
        InitializeComponent();      
    }
       

    private async Task<OrderWithDescriptionViewModel> CreateNewOrderAsync()
    {
        var text = await order.ToOrderDescriptionAsync();
        var currentOrder = new OrderWithDescriptionViewModel()
        {
            Id = new Guid(),
            OrderTime = DateTime.Now,
            Category = CategoryViewModel.Desinsection,
            
            Description = $"Тараканы - {(cockroachCheckBox.IsChecked ? "есть" : "нет")},\n" +
            $"Клопы - {(bugsCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"Блохи - {(fleasCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"Муравьи - {(antsCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"{text}"
        };

        return currentOrder;
    }



    private async void OrderButton_Clicked(object sender, EventArgs e)
    {
        var newOrder = new OrderWithDescriptionViewModel();
        newOrder = await CreateNewOrderAsync();
        var newOrderMesaageText = CreateNewMessageText(newOrder);

        var accessType = Connectivity.Current.NetworkAccess;
        if (accessType != NetworkAccess.Internet)
            await DisplayAlert("Ошибка", "Отсутствует соединение с интернетом", "ОK");
        else
        {
            EmailManager.SendEmail("Новый заказ из приложения. Дезинсекция", newOrderMesaageText);
            await Shell.Current.Navigation.PopAsync();
        }
    }

    private string CreateNewMessageText(OrderWithDescriptionViewModel newOrder)
    {
        var tempStringBuilder = new StringBuilder();
        tempStringBuilder.Append(newOrder.Category.ToString() + " \n" + newOrder.OrderTime.ToString() + " \n" + newOrder.Description);

        return tempStringBuilder.ToString();
    }
}