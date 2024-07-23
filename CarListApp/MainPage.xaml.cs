using CarListApp.ViewModels;

namespace CarListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CarsViewModel carsViewModel)
        {
            InitializeComponent();
            BindingContext = carsViewModel;
        }
    }

}
