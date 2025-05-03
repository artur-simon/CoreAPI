using AutoMapper;
using CoreAPI.Type;
using CoreAPI.Model;

namespace CoreAPI.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductType>();
    }
}