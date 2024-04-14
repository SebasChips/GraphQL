// Code: Program.cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Queries.SerieQuery>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
