
using Section4CustomMiddleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>(); // we have to added our custom middleware as a service so that our MyCustomMiddleware class can be accesible.
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// middleware 1
app.Use( async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1");
    await next(context);
});

// middleware 2,  which is custom middleware with name MyCustomMiddleware
app.UseMiddleware<MyCustomMiddleware>();

// Note: Instead of calling "app.Use" we have to call "app.UseMiddleware" that is another method So if you want to register a lambda expression as a middleware
// you can simply use "app.Use" but If you want to register a middleware class that is custom middleware class we have to call "app.UseMiddleware" by specifying
// the custom middleware class name as generic parameter.
// That's all.
// Note: Writing this "UseMiddleware" and then mentioning the class name is a bit lengthy code. We can simplify the same by creating an extension method and we will try that in the next lecture.

// middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Middleware 3");

});


app.Run();
