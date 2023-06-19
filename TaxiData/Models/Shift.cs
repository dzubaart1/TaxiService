using System.Diagnostics;
using TaxiData.Entities;

namespace TaxiData.Models
{
    public class Shift
    {
        public User? Dispatcher { get; private set; }
        public List<Driver> DriverList { get; private set; }

        public Shift()
        {
            Debug.WriteLine("----New Shift----");
            Dispatcher = null;
            DriverList = new List<Driver>();
        }

        public void ClearShift()
        {
            Dispatcher = null;
            DriverList.Clear();
        }

        public void SetDispatcher(User dispatcher)
        {
            Dispatcher = dispatcher;
        }

        public void AddDriver(Driver driver)
        {
            DriverList.Add(driver);
        }
    }
}
