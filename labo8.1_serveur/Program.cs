using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("labo8_1_serveurContext") ?? throw new InvalidOperationException("Connection string 'labo8_1_serveurContext' not found.");

builder.Services.AddDbContext<labo8_1_serveurContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(); // <--- Ajout #1

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowNext", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); // <--- Ajout #2
    app.UseSwaggerUI(); // <--- Ajout #3

}

app.UseHttpsRedirection();

app.UseCors("AllowNext");

app.UseAuthorization();

app.MapControllers();

app.Run();
