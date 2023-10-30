using DemoWebVuota;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<MyInterface, C>();
//builder.Services.AddSingleton<MyInterface, B>();
//builder.Services.AddTransient<MyInterface, B>();
builder.Services.AddScoped<MyInterface, B>();
builder.Services.AddScoped<A>();
builder.Services.AddSingleton<IMyTime, RealTime>();


var app = builder.Build();

app.MapGet("/",(MyInterface myInterface, A a) => {

    //MyInterface myInterface = new B();
    //MyInterface myInterface = new C();
    //var A = new A(myInterface);


    //MyAbstractClass myAbstractClass = new B1();
    //var A1 = new A1(myAbstractClass);

    return a.DoSomething() ;
});
app.Run();
