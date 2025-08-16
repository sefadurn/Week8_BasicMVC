var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();  // MVC servisini ekledik.
var app = builder.Build();

app.MapControllerRoute(
    
    name:"default",
    pattern:"{controller=CustomerOrders}/{action=index}"
    );

app.Run();
