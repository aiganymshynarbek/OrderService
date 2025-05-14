// Services/IOrderService.cs
using OrderService.Models;
using OrderService.Dtos;

namespace OrderService.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task<OrderDto?> GetByIdAsync(int id);
        Task<OrderDto> CreateAsync(Order order);
        Task<bool> DeleteAsync(int id);
    }
}
