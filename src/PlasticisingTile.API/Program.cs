﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PlasticisingTile.Core;
using PlasticisingTile.Infrastructure;
using PlasticisingTile.Infrastructure.Data.DataContexts;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new DefaultCoreModule()));
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new DefaultInfrastructureModule()));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAutoMapper(config =>
{
    config.AddMaps(Assembly.GetExecutingAssembly().GetName().Name);
    config.AddMaps(Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(a => a.Name));
});

builder.Services
    .AddDbContext<ConfigurationDataContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("ConfigurationData")));

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v0.1",
        Title = "Plasticising Tile API",
        Description = "An ASP.NET Core Web API for the Plasticising Tile"
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

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
