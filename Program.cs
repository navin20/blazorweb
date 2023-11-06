using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using blazorweb.Data;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<WeatherForecast>();
builder.Services.AddSingleton<Logining>();
builder.Services.AddSingleton<Registering>();
builder.Services.AddSingleton<QueryForFb>();
builder.Services.AddSingleton<HostingOnCloud>();
//  builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredSessionStorage();
   builder.Services.AddBlazoredLocalStorage();

//     builder.Services.AddSession(options =>
// {
//     options.IdleTimeout = TimeSpan.FromSeconds(1800);
//     options.Cookie.HttpOnly = true;
//     options.Cookie.IsEssential = true;
// });
 builder.Services.AddScoped<ProtectedLocalStorage>();
//  builder.Services.AddScoped<IComponentContext>();
//  builder.Services.AddScoped<ProtectedBrowserStorage>();
builder.Services.AddSession(options =>  
{  
    options.IdleTimeout = TimeSpan.FromSeconds(10);  //you can change the session expired time.  
    options.Cookie.HttpOnly = true;  
    options.Cookie.IsEssential = true;  
});  
builder.Services.AddDistributedMemoryCache();
// builder.Services.AddSession(options =>
// {
//     options.IdleTimeout = TimeSpan.FromSeconds(10);
//     options.Cookie.HttpOnly = true;
//     options.Cookie.IsEssential = true;
// });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
// app.Use(async (context, next) =>
// {
//     var token = context.Session.GetString("token");
//     if (!string.IsNullOrEmpty(token))
//     {
//         context.Request.Headers.Add("Authorization", "Bearer " + token);
//     }
//     await next();
// });
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
