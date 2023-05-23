 using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardWeb;
using Microsoft.Extensions.FileProviders;
using DXApplication1;

var builder = WebApplication.CreateBuilder(args);

IFileProvider? fileProvider = builder.Environment.ContentRootFileProvider;
IConfiguration? configuration = builder.Configuration;
builder.Services.AddCors();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDevExpressControls();
builder.Services.AddScoped<DashboardConfigurator>((IServiceProvider serviceProvider) => DashboardUtils.CreateDashboardConfigurator(configuration, fileProvider));
builder.Services.Configure<IISOptions>(options =>
{

});
var app = builder.Build(); 


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseDevExpressControls();

app.UseRouting();

// Registers CORS policies.
app.UseCors(options =>
{
    var frontendUrl = "http://localhost:3000";
    var serverUrl = "http://208.117.44.15/";
    options.WithOrigins(frontendUrl, serverUrl)
        .AllowAnyHeader()
        .AllowAnyMethod();
});
app.UseAuthorization();
app.MapRazorPages();

EndpointRouteBuilderExtension.MapDashboardRoute(app, "dashboardControl", "DefaultDashboard");
 
app.Run();