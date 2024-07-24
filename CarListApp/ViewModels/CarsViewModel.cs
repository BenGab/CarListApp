using CarListApp.Models;
using CarListApp.Services;
using CarListApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
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
            isRefreshing = false;
            this.carService = carService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GetCars()
        {
            try
            {
                if (IsLoading) return;
                IsLoading = true;
                isRefreshing = true;
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
                isRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GetCarDetails(Car car)
        {
            if(car == null) return;
            await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            {
                { nameof(Car), car }
            });
        }
    }       
}