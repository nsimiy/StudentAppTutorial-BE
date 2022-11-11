using Microsoft.EntityFrameworkCore;
using StudentAppTutorial_BE.App_Repositories.Implementation;
using StudentAppTutorial_BE.App_Repositories.Interface;
using StudentAppTutorial_BE.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//registering database
builder.Services.AddDbContext<STATDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("stoneConnectionString")));

//register repo
builder.Services.AddTransient<IRegisterRepo, RegisterRepo>();


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
