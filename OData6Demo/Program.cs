//using Microsoft.AspNetCore.OData;
//using OData6Demo.Services;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        var builder = WebApplication.CreateBuilder(args);

//        // Add services to the container.

//        builder.Services.AddControllers().AddOData(options =>
//                options.Select().Filter().OrderBy().Expand());
//        builder.Services.AddTransient<IStudentService, StudentService>();
//        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//        builder.Services.AddEndpointsApiExplorer();
//        builder.Services.AddSwaggerGen();

//        var app = builder.Build();

//        // Configure the HTTP request pipeline.
//        if (app.Environment.IsDevelopment())
//        {
//            app.UseSwagger();
//            app.UseSwaggerUI();
//        }

//        app.UseHttpsRedirection();

//        app.UseAuthorization();


//        app.MapControllers();

//        app.Run();
//    }
//}