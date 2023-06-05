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
        public List<Car> Download()
        {
            return MainService.GetJsonStorage().GetCars() ?? new List<Car>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_cars);
        }
    }
}
