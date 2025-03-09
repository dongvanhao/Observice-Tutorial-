namespace ObserverPatternAPI.Service
{
    public class OrderSubject
    {

        private readonly List<IObserver> _observers = new List<IObserver>();

        // Đăng ký Observer mới
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        // Hủy đăng ký Observer
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Gửi thông báo đến tất cả Observer
        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        // Giả lập tạo đơn hàng
        public void CreateOrder(string orderId)
        {
            Console.WriteLine($" Order {orderId} has been created!");
            Notify($"Order {orderId} Processed.");
        }
    }
}
