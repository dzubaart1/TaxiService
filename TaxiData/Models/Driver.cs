namespace TaxiData.Models
{
    public class Driver
    {
        private Car? _car;

        public Driver(RegistrationCard registrationCard)
        {
            RegistrationCard = registrationCard;
        }

        public RegistrationCard RegistrationCard { get; private set; }

        public void AddCar(Car car)
        {
            _car = car;
        }
    }
}
