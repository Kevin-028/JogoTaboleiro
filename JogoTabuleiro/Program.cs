var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

var teste = "dasdas";

var Gustavo = "viado";

var Henrique = "vida do Mathues";