using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.DTO;
using ProductService.Models;

namespace ProductService.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap(); //kazemo da se mapira product na productdto i reverse(obrnuto)
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderPart, OrderPartDto>().ReverseMap();
        }
    }
}
