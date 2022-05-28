using Passengers.Core.ValueObjects.DesignPatterns;

namespace Passengers.Core.ValueObjects.Utilities
{
    public interface IAddressBuilder : IBuilder<Address>
    {
        public IAddressBuilder MyStreetIs(string street);
        public IAddressBuilder WithPostalCode(string postalCode);
        public IAddressBuilder InCity(string city);
        public IAddressBuilder InStateOrProvince(string stateOrProvince);
        public IAddressBuilder InNation(string nation);
    }
}