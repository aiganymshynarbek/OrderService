using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;
using OrderService.Dtos;
using AutoMapper;

namespace OrderService.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderDbContext _context;
        private readonly IMapper _mapper;

        public OrderService(OrderDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var orders = await _context.Orders.ToListAsync();
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public async Task<OrderDto?> GetByIdAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            return order == null ? null : _mapper.Map<OrderDto>(order);
        }


        public async Task<OrderDto> CreateAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return _mapper.Map<OrderDto>(order);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
                return false;

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}