
using AutoMapper;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<ProductColor, ProductColorViewModel>().ReverseMap();
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }

}
