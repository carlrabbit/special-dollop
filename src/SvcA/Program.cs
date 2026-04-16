using LibA;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<GreetingService>();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { Service = "SvcA", Status = "OK" }));
app.MapGet("/greeting", (GreetingService greetingService) => Results.Ok(new GreetingResponse(greetingService.CreateGreeting("from LibA"))));

app.Run();

public sealed record GreetingResponse(string Message);
public partial class Program;
