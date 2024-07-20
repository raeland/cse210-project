namespace EventPlanning
{
    public class Address
    {
        public string _street { get; private set; }
        public string _city { get; private set; }
        public string _state { get; private set; }
        public string _zipCode { get; private set; }

        public Address(string street, string city, string state, string zipCode)
        {
            _street = street;
            _city = city;
            _state = state;
            _zipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{_street}, {_city}, {_state} {_zipCode}";
        }
    }
}