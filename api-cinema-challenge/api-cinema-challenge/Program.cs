using api_cinema_challenge.Controllers;
using api_cinema_challenge.Data;
using api_cinema_challenge.Reposetories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureMovieEndpoints();
app.ConfigureCustomerEndpoints();
app.ConfigureScreeningEndpoints();
app.Run();
