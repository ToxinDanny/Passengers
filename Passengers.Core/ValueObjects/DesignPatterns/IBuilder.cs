namespace Passengers.Core.ValueObjects.DesignPatterns
{
    public interface IBuilder<T> where T : class
    {
        public T Build();
    }
}
