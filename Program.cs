using SignalRWebpack.Hubs;

var builder = WebApplication.CreateBuilder(args);
// Add signalR to the program
builder.Services.AddSignalR();
var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<ChatHub>("/hub");

app.Run();
