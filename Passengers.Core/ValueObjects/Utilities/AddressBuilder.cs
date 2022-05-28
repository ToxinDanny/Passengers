namespace Passengers.Core.ValueObjects.Utilities
{
    public class AddressBuilder : IAddressBuilder
    {
        private readonly Address _address;

        public AddressBuilder(Address address)
        {
            _address = address;
        }

        public IAddressBuilder MyStreetIs(string street)
        {
            _address.Street = street;
            return this;
        }

        public IAddressBuilder WithPostalCode(string postalCode)
        {
            _address.PostalCode = postalCode;   
            return this;
        }

        public IAddressBuilder InCity(string city)
        {
            _address.City = city;
            return this;
        }

        public IAddressBuilder InNation(string nation)
        {
            _address.Nation = nation;
            return this;
        }

        public IAddressBuilder InStateOrProvince(string stateOrProvince)
        {
            _address.StateOrProvince = stateOrProvince;
            return this;
        }

        public Address Build()
        {
            return _address;
        }
    }
}
