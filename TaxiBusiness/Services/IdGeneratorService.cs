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

        public int GetNextId()
        {
            return _idGenerator.GenerateId();
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
