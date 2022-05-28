namespace Passengers.Core.Entities.Airplane
{
    public interface IAirplane
    {
        public string TailCode { get; set; }
        public IEnumerable<ISeat> Seats { get; set; }
        public bool IsFull { get; set; }
    }
}
