using Microsoft.AspNetCore.Mvc;
using ObserverPatternAPI.Service;
using ObserverPatternAPI.Service;

namespace ObserverPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderSubject _orderSubject;

        public OrderController(OrderSubject orderSubject)
        {
            _orderSubject = orderSubject;
        }

        [HttpPost("{id}")]
        public IActionResult CreateOrder(string id)
        {
            _orderSubject.CreateOrder(id);
            return Ok($"Order created {id}!");
        }

    }
}
