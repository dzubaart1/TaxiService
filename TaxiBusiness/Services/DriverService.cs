using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class DriverService : IService<List<Driver>>
    {
        private List<Driver> _drivers;

        public DriverService()
        {
            _drivers = Download();
        }

        public IReadOnlyCollection<Driver> Drivers => _drivers;
        public List<Driver> Download()
        {
            return MainService.GetJsonStorage().GetDrivers() ?? new List<Driver>();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_drivers);
        }

        public void Add(string name, int id)
        {
            RegistrationCard regCard = new RegistrationCard(name, id);
            _drivers.Add(new Driver(regCard));
        }

        public void Remove(int id)
        {
            Driver? targetDriver = _drivers.Find(driver => driver.RegistrationCard.Id.Equals(id));
            
            if(targetDriver != null)
            {
                _drivers.Remove(targetDriver);
            }
            else
            {
                throw new ArgumentException($"[-] There is not driver with id {id}");
            }
        }

        public void Remove(Driver driver)
        {
            _drivers.Remove(driver);
        }

        public void Edit(int id, string name)
        {
            var targetDriver = _drivers.Find(driver => driver.RegistrationCard.Id == id); //

            if (targetDriver is not null)
            {
                targetDriver.RegistrationCard.SetName(name);
            }
            else
            {
                throw new ArgumentException($"[-] There is not driver with id {id}");
            }
        }

        public Driver GetDriver(int id)
        {
            var res = _drivers.Find(driver => driver.RegistrationCard.Id.Equals(id));
            if (res is null)
            {
                throw new ArgumentException("[-] There is not id in the database");
            }
            return res;
        }
    }
}
