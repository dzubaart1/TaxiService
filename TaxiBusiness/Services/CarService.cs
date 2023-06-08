using System.Diagnostics;
using System.Drawing;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class CarService : IService<List<Car>>
    {
        private List<Car> _cars;

        public CarService()
        {
            _cars = Download();
        }

        public IReadOnlyCollection<Car> Cars => _cars;

        public void AddCar(Color color, string model, string vin)
        {
            _cars.Add(new Car(color, model, vin, MainService.GetIdGeneratorService().GetNextCarId()));
        }
        public void RemoveCar(Car car)
        {
            _cars.Remove(car);
        }
        public List<Car> Download()
        {
            return MainService.GetJsonStorage().GetCars() ?? new List<Car>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_cars);
        }

        public void Edit(int id, Color color, string model, string vin)
        {
            var targetCar = _cars.Find(car => car.Id.Equals(id));

            if (targetCar is not null)
            {
                targetCar.SetVin(vin);
                targetCar.SetColor(color);
                targetCar.SetModel(model);
            }
            else
            {
                throw new ArgumentException($"[-] There is not driver with id {id}");
            }
        }

        public Car GetCar(int id)
        {
            var res = _cars.Find(car => car.Id.Equals(id));
            if (res is null)
            {
                throw new ArgumentException("[-] There is not id in the database");
            }
            return res;
        }
    }
}
