﻿using AutoMapper;
using Next3.Application.ViewModels;
using Next3.Domain.Models;

namespace Next3.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Restaurant, RestaurantViewModel>();
            CreateMap<Address, AddressViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Order, OrderViewModel>();
            CreateMap<OrderItem, OrderItemViewModel>();
            CreateMap<OrderStatus, OrderStatusViewModel>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
