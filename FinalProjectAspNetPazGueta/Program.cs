using FinalProjectAspNetPazGueta;
using FinalProjectAspNetPazGueta.configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddRazorPages();
builder.Services.Configure<DatabaseSettings>(
builder.Configuration.GetSection("BookDatabase"));
builder.Services.AddSingleton<Startup>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

