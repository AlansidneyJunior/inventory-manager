using Microsoft.AspNetCore.Mvc;
using SalesService.Domain.Entities;
using SalesService.Infrastructure.Repositories;

namespace SalesService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderRepository _repository;

        public OrdersController(OrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _repository.GetAllAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task Create(Order order)
        {
            await _repository.AddAsync(order);
            await _repository.SaveChangesAsync();
        }
    }
}