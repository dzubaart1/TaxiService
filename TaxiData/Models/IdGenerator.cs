namespace TaxiData.Models
{
    public class IdGenerator
    {
        public int CurrentUserId;
        public int CurrentCarId;
        public int CurrentDriverId;

        public int GenerateUserId()
        {
            return ++CurrentUserId;
        }

        public int GenerateCarId()
        {
            return ++CurrentCarId;
        }

        public int GenerateDriverId()
        {
            return ++CurrentDriverId;
        }

    }
}
