using Passengers.Core.ValueObjects.Utilities;

namespace Passengers.Core.Entities.Passenger
{
    public class PassengerBuilder : IPassengerBuilder
    {
        private readonly Passenger _passenger;

        public PassengerBuilder(Passenger passenger)
        {
            _passenger = passenger;
        }

        public IPassengerBuilder BirthdateIs(DateOnly birthdate)
        {
            _passenger.Birthdate = birthdate;
            return this;
        }

        public IPassengerBuilder FirstNameIs(string firstName)
        {
            _passenger.FirstName = firstName;
            return this;
        }

        public IPassengerBuilder FiscalCodeIs(string fiscalCode)
        {
            _passenger.FiscalCode = fiscalCode;
            return this;    
        }

        public IPassengerBuilder LastNameIs(string lastName)
        {
            _passenger.LastName = lastName;
            return this;
        }

        public IPassengerBuilder PhoneNumberIs(int phoneNumber)
        {
            _passenger.PhoneNumber = phoneNumber;
            return this;
        }

        public IPassengerBuilder WithAddress(Address address)
        {
            _passenger.Address = address;
            return this;
        }

        public Passenger Build()
        {
            return _passenger;  
        }
    }
}
