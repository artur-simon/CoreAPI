
using CoreAPI.Mapper;
using CoreAPI.Query;
using CoreAPI.Type;

var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL()
    .AddQueryType<ProductQuery>()
    .AddType<ProductType>();

var services = builder.Services;

services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

app.MapGraphQL();
app.UseGraphQLGraphiQL();

app.Run();
