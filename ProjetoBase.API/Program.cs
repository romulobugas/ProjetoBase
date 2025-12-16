using NHibernate;
using ProjetoBase.API.Repositories;
using ProjetoBase.API.Repositories.Interfaces;
using ProjetoBase.API.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISessionFactory>(sp =>
    NhSessionFactoryBuilder.Build(sp.GetRequiredService<IConfiguration>()));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
