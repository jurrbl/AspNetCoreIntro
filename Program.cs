using AspNetCoreIntro.Services;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IUsersService, UsersInMemoryService>();
builder.Services.AddSingleton<IUsersService, UsersSqlServerService>();
//aggiungo supporto al controller

builder.Services.AddControllersWithViews();

var app = builder.Build();


// Per utilizzare file css, js, etc.... contenuti nella cartella wwwroot 
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
