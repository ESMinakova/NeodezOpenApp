using NeodezMobApp.ViewModels;

namespace NeodezMobApp.Views;

public partial class ProductPage : ContentPage
{
    public ProductViewModel product { get; private set; }
    public ProductPage(ProductViewModel productVM)
    {
        InitializeComponent();
        product = productVM;
        this.BindingContext = product;
    }

    public async void OnOrderButtonClicked(object sender, EventArgs e)
    {
        if (BindingContext is ProductViewModel product)
        {
            switch (product.Category)
            {
                case CategoryViewModel.Desinsection:
                    await Shell.Current.Navigation.PushAsync(new DesinsectionOrderPage());
                    break;
                case CategoryViewModel.Desinfection:
                    await Shell.Current.Navigation.PushAsync(new DesinfectionOrderPage());
                    break;
                case CategoryViewModel.Deratisation:
                    await Shell.Current.Navigation.PushAsync(new DeratisationOrderPage());
                    break;
                case CategoryViewModel.Desmicology:
                    await Shell.Current.Navigation.PushAsync(new DesmicologyOrderPage());
                    break;
                case CategoryViewModel.Acaricid:
                    await Shell.Current.Navigation.PushAsync(new AcaricidOrderPage());
                    break;
                case CategoryViewModel.CommonCleaning:
                    await Shell.Current.Navigation.PushAsync(new CommonCleaningOrderPage());
                    break;
                case CategoryViewModel.AfterRefitCleaning:
                    await Shell.Current.Navigation.PushAsync(new AfterRefitCleaningOrderPage());
                    break;
                case CategoryViewModel.DryCleaning:
                    await Shell.Current.Navigation.PushAsync(new DryCleaningOrderPage());
                    break;
            }
        }
    }
}