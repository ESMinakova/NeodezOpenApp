using NeodezMobApp.ViewModels;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace NeodezMobApp.Views;

public partial class DeratisationOrderPage : ContentPage
{

    public DeratisationOrderPage()
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
            Category = CategoryViewModel.Deratisation,
            Description = $"����� ��������� - {districtEntry.Text} \n" +
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
            await DisplayAlert("������", "����������� ���������� � ����������", "�K");
        else
        {
            EmailManager.SendEmail("����� ����� �� ����������. �����������", newOrderMesaageText);
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