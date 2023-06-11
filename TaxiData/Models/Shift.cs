using TaxiData.Entities;

namespace TaxiData.Models
{
    public class Shift
    {
        public User? Dispatcher { get; private set; }
        public List<Driver>? DriverList { get; private set; }
        public Shift(User dispatcher, List<Driver> drivers)
        {
            Dispatcher = dispatcher;
            DriverList = drivers;
        }

        public Shift()
        {
        }
    }
}
