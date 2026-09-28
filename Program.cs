using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Nordic;
using Nordic.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Xizmatlarni shu yerda ro'yxatdan o'tkazamiz (Build'dan oldin)
builder.Services.AddScoped<ProductService>();

builder.Services.AddScoped<CartService>();

await builder.Build().RunAsync();
