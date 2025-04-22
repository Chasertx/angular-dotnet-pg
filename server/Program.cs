using Microsoft.EntityFrameworkCore;
using Playground.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

//Add controllers
builder.Services.AddControllers();

//Add CORS policy
builder.Services.AddCors(options =>{
    options.AddPolicy("AllowAngularApp",
        policy =>{
            policy.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

//Adding the SQL DB Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Adding some api documentation here
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Portfolio API", 
        Version = "v1",
        Description = "Backend API for portfolio project"
    });
});

var app = builder.Build();

app.UseCors();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();
