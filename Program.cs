using AutoMapper;
using IntegracaoBrasilApi;
using IntegracaoBrasilApi.Mappings;
using IntegracaoBrasilApi.Rest;
using IntegracaoBrasilApi.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IEnderecoService, EnderecoService>();
builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));

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


