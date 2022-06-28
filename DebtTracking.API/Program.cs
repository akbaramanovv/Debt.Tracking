using DebtTracking.Application;
using DebtTracking.Application.Handlers.CommandHandler.Customer;
using DebtTracking.Core;
using DebtTracking.Core.Repositories.Command;
using DebtTracking.Core.Repositories.Command.Base;
using DebtTracking.Core.Repositories.Query;
using DebtTracking.Core.Repositories.Query.Base;
using DebtTracking.Infrastrucuture;
using DebtTracking.Infrastrucuture.Data.Context;
using DebtTracking.Infrastrucuture.Repository.Command.Base;
using DebtTracking.Infrastrucuture.Repository.Query;
using DebtTracking.Infrastrucuture.Repository.Query.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCore();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

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
