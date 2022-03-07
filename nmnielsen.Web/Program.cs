using Auth0.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Domain;
using nmnielsen.Repository.Interfaces;
using nmnielsen.Repository.Repositories;
using nmnielsen.Service.Interfaces;
using nmnielsen.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region Scopes
// Mapping
builder.Services.AddScoped<MappingService, MappingService>();

// Project
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();
#endregion

builder.Services.AddRazorPages();

builder.Services.AddDbContext<NMNielsenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection"))
    .EnableSensitiveDataLogging(true));

builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
    options.ClientSecret = builder.Configuration["Auth0:ClientSecret"];
    options.Scope = "openid profile email";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<NMNielsenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    .EnableSensitiveDataLogging(false));

    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();