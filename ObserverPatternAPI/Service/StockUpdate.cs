namespace ObserverPatternAPI.Service
{
    public class StockUpdate : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Stock Update: {message}");
        }
    }
}
