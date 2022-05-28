using Passengers.Core.ValueObjects.DesignPatterns;
using Passengers.Core.ValueObjects.Utilities;

namespace Passengers.Core.Entities.Passenger
{
    public interface IPassengerBuilder : IBuilder<Passenger>
    {
        public IPassengerBuilder FirstNameIs(string firstName); 
        public IPassengerBuilder LastNameIs(string lastName); 
        public IPassengerBuilder BirthdateIs(DateOnly birthdate); 
        public IPassengerBuilder PhoneNumberIs(int phoneNumber); 
        public IPassengerBuilder FiscalCodeIs(string fiscalCode); 
        public IPassengerBuilder WithAddress(Address address); 
    }
}