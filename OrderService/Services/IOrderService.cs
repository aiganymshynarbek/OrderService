// Services/IOrderService.cs
using OrderService.Models;

namespace OrderService.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task<Order> CreateAsync(Order order);
        Task<bool> DeleteAsync(int id);
    }
}
