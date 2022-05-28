namespace Passengers.Core.Entities.Ticket
{
    public interface ITicket
    {
        public string Code { get; set; }
        public string PassengerFiscalCode { get; set; }
        public string SeatCode { get; set; }
        public Money Price { get; set; }
    }
}
