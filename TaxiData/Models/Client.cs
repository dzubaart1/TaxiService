namespace TaxiData.Models
{
    public class Client
    {
        public string? Satisfaction { get; private set; }
        public string Name { get; private set; }
        public Client(string name)
        {
            Name = name;
        }
        public void SetSatisfaction(string satisfaction)
        {
            Satisfaction = satisfaction;
        }
    }
}
