
using CarListApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListApp.ViewModels
{
    public partial class CarDetailsViewModel : BaseViewModel,  IQueryAttributable
    {

        [ObservableProperty]
        Car car;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Car = query["Car"] as Car;
            Title = $"Car detail - {Car.Model} - {Car.Make}";
        }
    }
}
