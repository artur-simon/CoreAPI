namespace CoreAPI.Type;

public class ProductType
{
    [GraphQLName("id")]
    [GraphQLDescription("Identificador único do produto.")]
    public string Id { get; set; }

    [GraphQLName("estoque")]
    [GraphQLDescription("Quantidade disponível em estoque.")]
    public string Estoque { get; set; }

    [GraphQLName("nome")]
    [GraphQLDescription("Nome do produto.")]
    public string Nome { get; set; }

    [GraphQLName("preco")]
    [GraphQLDescription("Preço do produto.")]
    public string Preco { get; set; }
}