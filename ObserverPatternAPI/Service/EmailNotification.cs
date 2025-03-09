namespace ObserverPatternAPI.Service
{
    public class EmailNotification : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
