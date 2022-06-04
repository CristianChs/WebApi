
using WebApi;
using WebApi.Middlewares;
using WebApi.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//configuramos el entity
builder.Services.AddSqlServer<TareasContext>("Data Source=192.168.0.26,1433;Initial Catalog=TareasDb;User ID=sa;Password=alegro123");
//inyeccion de dependencias
builder.Services.AddScoped<IHelloWorldService,HelloWorldService>();
builder.Services.AddScoped<ICategoria,CategoriaService>();
builder.Services.AddScoped<ITareas,TareasService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseWelcomePage();
//app.UseTimeMiddleware();
app.MapControllers();

app.Run();
