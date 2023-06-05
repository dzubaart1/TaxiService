using System.Drawing;

namespace TaxiData.Models
{
    public class Car
    {
        private Color _color;
        private string _model;
        private VIN _vin;

        public Car(Color color, string model, string vin)
        {
            _color = color;
            _model = model;
            _vin = new VIN(vin);
        }

        private class VIN
        {
            public string Value { get; private set;}

            public VIN(string value)
            {
                if(value.Length != 6)
                {
                    return;
                }

                if (char.IsLetter(value[0])&&
                    char.IsDigit(value[1])&&
                    char.IsDigit(value[2])&&
                    char.IsDigit(value[3]) &&
                    char.IsLetter(value[4]) &&
                    char.IsLetter(value[5]))
                {
                    Value = value;
                }
                else
                {
                    throw new ArgumentException("[-] Invalid VIN");
                }
            }

        }
    }
    
}
