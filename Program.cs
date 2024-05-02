using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using OnlineStore_Blazor.Data;
using OnlineStore_Blazor.Models;
using OnlineStore_Blazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Añadir servicios al contenedor.
builder.Services.AddSingleton<ShoppingCart>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddHttpClient<IProductService, ProductService>();
builder.Services.AddSingleton<ShippingInfoService>();


var app = builder.Build();

// Configurar la línea de solicitudes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
