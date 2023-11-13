using BOMS.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BOMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BOMSContext") ?? throw new InvalidOperationException("Connection string 'BOMSContext' not found.")));
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<OrderService>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<ICustomerData, CustomerData>();
builder.Services.AddSingleton<CustomerData, CustomerData>();
builder.Services.AddSingleton<SqlDataAccess, SqlDataAccess>();


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


app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
