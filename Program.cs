var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/datetime", () =>
{
    var dateTime = DateTime.Now;
    return Results.Text(dateTime.ToString());
});

app.Run();
