namespace TaxiData.Models
{
    public class IdGenerator
    {
        public int CurrentId;

        public int GenerateId()
        {
            return ++CurrentId;
        }
    }
}
