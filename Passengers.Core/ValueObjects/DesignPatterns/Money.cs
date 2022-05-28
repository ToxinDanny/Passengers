using Passengers.Core.ValueObjects.Enums;

namespace Passengers.Core.ValueObjects.DesignPatterns
{
    public class Money
    {
        public long Amount { get; set; }
        public Currency Currency { get; set; }

        public static Money Change(Money change, Currency to)
        {
            if(change.Currency == to)
            {
                return change;
            }

            // TODO: completare
            return new Money
            {
                Amount = change.Amount * (int)to / (int)Currency.Euro,
                Currency = to
            };
        }

        public static Money operator*(Money first, Money second)
        {
            var secondChanged = Change(second, first.Currency);
            
            return new Money
            {
                Amount = first.Amount * secondChanged.Amount,
                Currency = first.Currency   
            };
        }

        // TODO: completare
        public IEnumerable<Money> Allocate(long[] ratios)
        {
            return new List<Money>();
        }
    }
}
