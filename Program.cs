
using LearningBackend.Data;
using Microsoft.EntityFrameworkCore;
//using LearningBackend.Models; // or your AppDbContext's namespace

var builder = WebApplication.CreateBuilder(args);

// Add EF Core (Use Sqlite / SQL Server / Postgres etc.)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

// Enable Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();