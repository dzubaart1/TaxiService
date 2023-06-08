using TaxiData.Models;

namespace TaxiBusiness.Services
{
    public class IdGeneratorService : IService<IdGenerator>
    {
        private IdGenerator _idGenerator;

        public IdGeneratorService()
        {
            _idGenerator = Download();
        }

        public int GetNextUserId()
        {
            return _idGenerator.GenerateUserId();
        }

        public int GetNextCarId()
        {
            return _idGenerator.GenerateCarId();
        }
        public int GetNextDriverId()
        {
            return _idGenerator.GenerateDriverId();
        }


        public IdGenerator Download()
        {
            return MainService.GetJsonStorage().GetIdGenerator() ?? new IdGenerator();
        }

        public void Upload()
        {
            MainService.GetJsonStorage().Save(_idGenerator);
        }
    }
}
