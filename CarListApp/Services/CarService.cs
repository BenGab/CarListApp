using CarListApp.Models;

namespace CarListApp.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car { Id = 1, Make = "Toyota", Model = "Corolla", Vin = "JTDBR32E720017891" },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Vin = "2HGFB2F56DH517050" },
                new Car { Id = 3, Make = "Ford", Model = "Mustang", Vin = "1FA6P8CF6K5154463" },
                new Car { Id = 4, Make = "Chevrolet", Model = "Camaro", Vin = "1G1FF1R74K0102030" },
                new Car { Id = 5, Make = "BMW", Model = "X5", Vin = "5UXKR0C57E0P20997" },
                new Car { Id = 6, Make = "Audi", Model = "A4", Vin = "WAUBFAFLXGN007596" },
                new Car { Id = 7, Make = "Mercedes-Benz", Model = "C-Class", Vin = "WDDGF8AB5DA760210" }
            };
        }
    }
}
