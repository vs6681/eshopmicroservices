var builder = WebApplication.CreateBuilder(args);
//add the services here 


var app = builder.Build();

// http pipeline
app.Run();
