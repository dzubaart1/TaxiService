using System.Diagnostics;
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

        public Shift Shift => _shift;
        public Shift Download()
        {
            Debug.WriteLine("-------DOWNLOAD----------");
            return MainService.GetJsonStorage().GetShift() ?? new Shift();
        }

        public void Upload()
        {
            Debug.WriteLine("-------SAVE----------");
            MainService.GetJsonStorage().Save(_shift);
        }

        public void Set(Shift shitf)
        {
            ClearShift();
            _shift = shitf;
        }

        public void ClearShift()
        {
            _shift.ClearShift();
        }
    }
}
