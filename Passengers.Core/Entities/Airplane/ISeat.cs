using Passengers.Core.ValueObjects.Enums;

namespace Passengers.Core.Entities.Airplane
{
    public interface ISeat
    {
        public string Code { get; set; }
        public SeatType Type { get; set; }
    }
}
