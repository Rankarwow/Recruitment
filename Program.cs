using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Recruitment.Data;
using System;

var builder = WebApplication.CreateBuilder(args);
//ready for deployment, just update "RecruitmentContext": "" string in appsettings.json
/*builder.Services.AddDbContext<RecruitmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RecruitmentContext") ?? throw new InvalidOperationException("Connection string 'RecruitmentContext' not found.")));*/
// Add services to the container.
builder.Services.AddDbContext<RecruitmentContext>(db => db.UseInMemoryDatabase("Test"));
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
