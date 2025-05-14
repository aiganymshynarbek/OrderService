using AutoMapper;
using OrderService.Models;
using OrderService.Dtos;

namespace OrderService.Mappings
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }
    }
}
