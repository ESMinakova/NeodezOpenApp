using NeodezMobApp.ViewModels;
using System.Collections.ObjectModel;

namespace NeodezMobApp.Views;

public partial class AllProductsPage : ContentPage
{

	public AllProductsPage()	
    {        
        InitializeComponent();        
        this.BindingContext = new AllProductsViewModel();        
    }

    private async void productList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the product model
            var product = (ProductViewModel)e.CurrentSelection[0];
            
            await Shell.Current.Navigation.PushAsync(new ProductPage(product));            

            // Unselect the UI
            productList.SelectedItem = null;
        }
    }
    public async void OnTapped(object sender, EventArgs e)
    {

        var stack = sender as StackLayout;
        var context = stack.BindingContext;
        if (context is ProductViewModel product)
            await Shell.Current.Navigation.PushAsync(new ProductPage(product));

    }

}