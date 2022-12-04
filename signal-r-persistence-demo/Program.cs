using signal_r_persistence_demo.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<MyHub>("/myhub");

app.MapGet("/", () => "Hello World!");

app.Run();
