using BabuDinner.Application;
using BabuDinner.Infrastructure;

try
{
    var builder = WebApplication.CreateBuilder(args);
    {
        builder.Services.AddApplication().AddInfrastructure();
        builder.Services.AddControllers();
    }

    var app = builder.Build();
    {
        app.UseHttpsRedirection();
        app.MapControllers();
    }
    app.Run();
}
catch (Exception ex)
{

    throw new Exception("Error in Program.cs", ex);
}



