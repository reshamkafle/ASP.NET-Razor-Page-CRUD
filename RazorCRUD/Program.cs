using Microsoft.EntityFrameworkCore;
using RazorCRUD.Data;
using RazorCRUD.Interfaces;
using RazorCRUD.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomerDBContext>(options =>
    options.UseInMemoryDatabase("demo"));

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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
