using AutoMapper;
using MyShopNetSix.Entities;
using MyShopNetSix.Models;

namespace MyShopNetSix.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
        }
    }
}
