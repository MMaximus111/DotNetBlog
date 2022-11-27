using DotNetBlog.Application;
using DotNetBlog.Web.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(typeof(IApplicationAssemblyMarker).Assembly);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

WebApplication app = builder.Build();

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