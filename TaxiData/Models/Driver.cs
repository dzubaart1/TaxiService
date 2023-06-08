namespace TaxiData.Models
{
    public class Driver
    {
        public int Id { get; private set; }
        private Car? _car;

        public Driver(RegistrationCard registrationCard, int id)
        {
            RegistrationCard = registrationCard;
            Id = id; 
        }

        public RegistrationCard RegistrationCard { get; private set; }

        public void AddCar(Car car)
        {
            _car = car;
        }
    }
}
