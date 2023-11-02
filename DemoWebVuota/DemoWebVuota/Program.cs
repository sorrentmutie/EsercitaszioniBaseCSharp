using DemoWebVuota;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<MyInterface, C>();
//builder.Services.AddSingleton<MyInterface, B>();
//builder.Services.AddTransient<MyInterface, B>();
builder.Services.AddScoped<MyInterface, B>();
builder.Services.AddScoped<A>();
builder.Services.AddSingleton<IMyTime, RealTime>();

var app = builder.Build();




//app.UseWelcomePage();
app.UseStaticFiles();



app.Use( async (context, next) =>
{
    app.Logger.LogCritical("Middleware 1");
    if (context.Request.Path == "/ciao")
    {
        await context.Response.WriteAsync("Ciao");
    }
    else
    {
        await next();
    }

   // await context.Response.WriteAsync("Hello World!");
   // await next();
});

app.Use(async (context, next) =>
{
    app.Logger.LogCritical("Middleware 2");
    // await context.Response.WriteAsync("Hello World!");
    await next();
});


app.MapGet("/",(MyInterface myInterface, A a) => {
    return a.DoSomething();
});
app.Run();
