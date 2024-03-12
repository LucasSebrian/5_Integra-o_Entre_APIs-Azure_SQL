using AddressService;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("Azure_connection_string");

builder.Services.AddDbContext<AdventureFiapContext>(options => options.UseSqlServer(connection));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AddressService API", Version = "v1" }); // Substitua "AddressService API" pelo nome correto
});
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/Addresses/{id}", async (AdventureFiapContext context, int id) =>
{
    var customerAddress = await context.CustomerAddresses
    .Where(ca => ca.CustomerId == id)
    .Select(ca => ca.AddressId)
    .ToListAsync();

var addressList = await context.Addresses
    .Where(a => customerAddress.Contains(a.AddressId))
    .Select(a => new
    {
        a.AddressLine1,
        a.AddressLine2,
        a.City,
        a.StateProvince,
        a.CountryRegion,
        a.PostalCode,
        a.Rowguid,
        a.ModifiedDate
    })
    .ToListAsync();

return new
{
    Addresses = addressList
};

})
.WithName("Get Addresses By Address ID")
.WithOpenApi();

app.Run();
