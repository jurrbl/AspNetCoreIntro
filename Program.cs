using AspNetCoreIntro.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IUsersService, UsersService>();
//aggiungo supporto al controller

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
