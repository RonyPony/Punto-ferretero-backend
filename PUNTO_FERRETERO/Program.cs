using PUNTO_FERRETERO.CORE.INTERFACE;
using PUNTO_FERRETERO.CORE.SERVICES;
using PUNTO_FERRETERO.DATA.CONTRACT;
using PUNTO_FERRETERO.DATA.REPOSITORY;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Services injection 

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserService>();/*
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductService, ProductService>();
*/

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
