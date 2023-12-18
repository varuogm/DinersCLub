using BabuDinner.Application.Services.Authentication;

try
{
    var builder = WebApplication.CreateBuilder(args);
    {
        builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();
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

    throw ex;
}



