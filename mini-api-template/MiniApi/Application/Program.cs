// See https://fast-endpoints.com/docs/get-started for more information
global using FastEndpoints;
global using FastEndpoints.Security;
global using FluentValidation.Results;

WebApplicationBuilder builder = WebApplication.CreateBuilder();

// Configure services
builder.Services.AddFastEndpoints();
builder.Services.AddJWTBearerAuth("TokenSigningKey");

// Middleware
WebApplication app = builder.Build();

app.UseDefaultExceptionHandler();
app.UseAuthentication();
app.UseAuthorization();
app.UseFastEndpoints(c =>
{
    c.Endpoints.Configurator = ep =>
    {
        ep.PostProcessors(Order.After, new ErrorLogger());
    };
});

app.Run();
