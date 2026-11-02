using OneBountyPiece.Hub.Service;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<CFactory>();
builder.Services.AddScoped<AddressSrv>();
builder.Services.AddScoped<CrewSrv>();
builder.Services.AddScoped<DevilFruitSrv>();
builder.Services.AddScoped<PermissionSrv>();
builder.Services.AddScoped<PirateSrv>();
builder.Services.AddScoped<RolePermissionSrv>();
builder.Services.AddScoped<RoleSrv>();
builder.Services.AddScoped<ShightingsSrv>();
builder.Services.AddScoped<ShipSrv>();
builder.Services.AddScoped<SystemUserSrv>();
builder.Services.AddScoped<TypeShipSrv>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
