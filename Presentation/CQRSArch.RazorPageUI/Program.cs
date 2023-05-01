using CQRSArch.Persistence.Data.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
builder.Services.RegisterServices(builder.Configuration);
//DependenciesContainer.InjectServices(builder.Services, builder.Configuration.GetConnectionString("CQRSArchConnectionString"));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});

app.Run();
