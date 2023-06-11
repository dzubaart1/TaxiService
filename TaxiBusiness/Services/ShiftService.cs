using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class ShiftService : IService<Shift>
    {
        private Shift _shift;

        public ShiftService()
        {
            _shift = Download();
        }

        public Shift Shifts => _shift;
        public Shift Download()
        {
            return MainService.GetJsonStorage().GetShift() ?? new Shift();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_shift);
        }

        public void Add(User dispatcher, List<Driver> drivers)
        {
            _shift = new Shift(dispatcher, drivers);
        }

        public void ClearShift()
        {
            _shift = null;
        }

        public User? GetDispatcher()
        {
            return _shift.Dispatcher;
        }
    }
}
