using DemoPadel.Data;
using Microsoft.EntityFrameworkCore;
using Padel.Core.Entities;
using Padel.Core.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opzioni =>
{
    opzioni.AddPolicy("CorsPolicy", builder => 
           builder.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader());
});

builder.Services.AddDbContext<PadelDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PadelDataContext")));
builder.Services.AddScoped<IDatiIstruttori, ServizioDatiIstruttoriPadelSQLServer>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

var istruttori = app.MapGroup("/istruttori");

istruttori.MapGet("/", async (IDatiIstruttori servizio) => { 
    return await servizio.EstraiIstruttoriDisponibiliAsync();
});

istruttori.MapGet("/{id}", async (IDatiIstruttori servizio, int id) =>
       await servizio.EstraiIstruttorePerIdAsync(id) is IstruttorePadel istruttore
         ? Results.Ok(istruttore) // 200
         : Results.NotFound());  // 404

istruttori.MapPost("/", async (IDatiIstruttori servizio, IstruttorePadel istruttore) => {
    await servizio.AggiungiIstruttoreDisponibileAsync(istruttore);
    // return Results.StatusCode(201); // 201 created
    return Results.Created($"/istruttori/{istruttore.Id}", istruttore);
});

istruttori.MapDelete("/{id}", async (IDatiIstruttori servizio, int id) =>
{
    var istruttore = await servizio.EstraiIstruttorePerIdAsync(id);
    if (istruttore == null) return Results.NotFound();
    await servizio.EliminaIstruttoreDisponibileAsync(istruttore);
    return Results.NoContent(); // 204
});

istruttori.MapPut("/{id}", async (IDatiIstruttori servizio, int id,
    IstruttorePadel istruttoreModificato) =>
    {
        if(istruttoreModificato.Id != id) return Results.BadRequest(); // 400
        var istruttoreDb = await servizio.EstraiIstruttorePerIdAsync(id);
        if(istruttoreDb == null) return Results.NotFound(); // 404
        await servizio.ModificaIstruttoreDisponibileAsync(istruttoreModificato);
        return Results.NoContent(); // 204
    });

istruttori.MapPatch("/{id}",
    async (IDatiIstruttori servizio, int id,
    IstruttorePadel istruttoreModificato) =>
    {
        if (istruttoreModificato.Id != id) return Results.BadRequest(); // 400
        var istruttoreDb = await servizio.EstraiIstruttorePerIdAsync(id);
        if (istruttoreDb == null) return Results.NotFound(); // 404
        await servizio.PatchIstruttoreDisponibileAsync(istruttoreModificato);
        return Results.NoContent(); // 204
    });


app.Run();