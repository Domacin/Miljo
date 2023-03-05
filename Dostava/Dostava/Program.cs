using Dostava.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//add cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Poruci_CORS", policy =>
    {
        policy.WithOrigins("http://localhost:4200/");
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PoruciDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection")));

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x=> x.
        AllowAnyOrigin().
        AllowAnyHeader().
        AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
