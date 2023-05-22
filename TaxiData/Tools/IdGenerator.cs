namespace TaxiData.Tools
{
    public class IdGenerator
    {
        public int CurrentId { get; private set; }

        public int GenerateId()
        {
            return ++CurrentId;
        }
    }
}
