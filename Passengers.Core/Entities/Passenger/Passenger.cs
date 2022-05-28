using Passengers.Core.ValueObjects.Utilities;

namespace Passengers.Core.Entities.Passenger
{
    public class Passenger : IPassenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public int PhoneNumber { get; set; }
        public string FiscalCode { get; set; }
        public Address Address { get; set; }
    }
}
