

using Application;
using Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddInfrastructure(builder.Configuration);
var assembly = Assembly.GetExecutingAssembly();
builder.Services.AddApplication();
builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiCorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("ApiCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
