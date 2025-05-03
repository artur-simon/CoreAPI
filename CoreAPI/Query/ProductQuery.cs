using AutoMapper;
using CoreAPI.Type;
using CoreAPI.Model;

namespace CoreAPI.Query
{
    public class ProductQuery
    {
        private readonly IMapper _mapper;

        public ProductQuery(IMapper mapper)
        {
            _mapper = mapper;
        }

        [GraphQLName("product")]
        public ProductType GetProduct(int id) {
            var product =  new Product
            {
                Id = id,
                Estoque = 1,
                Nome = "Sample product",
                Preco = 12
            };
            return _mapper.Map<ProductType>(product);
        }
    }
}
