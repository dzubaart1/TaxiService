using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiData.Entities;
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

        public void Edit(int id, string name)
        {
            Driver? targetDriver = _drivers.Find(driver => driver.RegistrationCard.Id.Equals(id));

            if (targetDriver != null)
            {
                targetDriver.RegistrationCard.SetName(name);
            }
            else
            {
                throw new ArgumentException($"[-] There is not driver with id {id}");
            }
        }
    }
}
