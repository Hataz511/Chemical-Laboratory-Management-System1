using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using backend.Models;
using backend.Services;
using backend.Data;

var builder = WebApplication.CreateBuilder(args);

// Register repositories and services (Dependency Injection)
builder.Services.AddSingleton<IRepository<Chemical>, FileRepository<Chemical>>();
builder.Services.AddSingleton<IRepository<User>, FileRepository<User>>();
builder.Services.AddSingleton<IChemicalService, ChemicalService>();

builder.Services.AddControllers(); // Map API endpoints or controllers

var app = builder.Build();

// Map controllers or API routes
app.MapControllers();

// Run the backend application
app.Run();