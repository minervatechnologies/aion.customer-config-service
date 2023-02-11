using Aion.CustomerConfigService.Application.Repositories;
using Aion.CustomerConfigService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices(builder.Configuration);

//builder.Services.AddDbContext<CustomerConfigDbContext>(options =>
//                options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=someThingComplicated1234"));

builder.Services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICustomerGroupTemplateRepository, CustomerGroupTemplateRepository>();
builder.Services.AddScoped<ICustomerGroupSpecificationRepository, CustomerGroupSpecificationRepository>();

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

