var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/",() =>
{
    return "Polleria Travis Scott conectada";
});

app.MapGet("/api/polleria",() =>
{
    return Results.Ok(new[]
    {
        new {
            id=1,
            codigo="P001",
            nombre="Pollo a la Brasa",
        },
        new {
            id=2,
            codigo="P002",
            nombre="Pollo Broaster",
        }
    });
});

app.Run();