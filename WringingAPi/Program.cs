using Microsoft.EntityFrameworkCore;
using WringingAPi.Configuration;
using WringingAPi.Data;
using WringingAPi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adiciona suporte para controladores
builder.Services.AddControllers(); // <--- Adicione esta linha
builder.Services.AddScoped<IFilmeService, FilmeService>();

builder.Services.AddHttpClient<IFilmeClient, FilmeClient>(client =>
{
    client.BaseAddress = new Uri("https://www.omdbapi.com/");
});

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapeia os controladores
app.MapControllers();

app.Run();