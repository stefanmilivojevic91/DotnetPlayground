using APIUsingDifferentProtocols;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services
    .AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddScoped<ProjectsService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<ProjectQuery>();

var app = builder.Build();

app.MapGraphQL();

app.MapPost("api/projects", (ProjectsService service) =>
{

});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
