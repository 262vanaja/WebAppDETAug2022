using Microsoft.EntityFrameworkCore;
//using TodoApi.Data;
using Microsoft.Extensions.DependencyInjection;
using TodoAPi.Data;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TodoAPiContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("TodoAPiContext") ?? throw new InvalidOperationException("Connection string 'TodoAPiContext' not found.")));

// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddDbContext<TodoContext>(opt =>
//    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseDefaultFiles();

    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();