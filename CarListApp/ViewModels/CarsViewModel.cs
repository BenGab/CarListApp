using CarListApp.Models;
using CarListApp.Services;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CarListApp.ViewModels
{
    public partial class CarsViewModel : BaseViewModel
    {
        private readonly CarService carService;

        public ObservableCollection<Car> Cars { get; private set; } = new ();

        public CarsViewModel(CarService carService)
        {
            Title = "Car List";
            this.carService = carService;
        }

        [RelayCommand]
        async Task GetCars()
        {
            try
            {
                if (IsLoading) return;
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();
                carService.GetCars().ForEach(car => Cars.Add(car));
            }
            catch (Exception ex)
            { 
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retreive cars", "Ok");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }       
}
