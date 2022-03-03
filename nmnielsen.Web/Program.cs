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

builder.Services.AddDbContext<NmnielsenContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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