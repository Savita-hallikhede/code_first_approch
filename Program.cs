using code_first_approch.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var MyConKey= builder.Configuration.GetConnectionString("MVCCon");
builder.Services.AddDbContext<MyDataBaseContext>(S => S.UseSqlServer(MyConKey));

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Register}/{action=RegisterdataShow}/{id?}");

app.Run();
