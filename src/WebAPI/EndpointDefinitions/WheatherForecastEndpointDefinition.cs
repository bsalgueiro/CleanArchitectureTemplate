using Carter;

namespace WebAPI.EndpointDefinitions;

public class WheatherForecastEndpointDefinition : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/wheatherforecast", GetWheatherForecast)
            .WithName("GetWeatherForecast")
            .WithOpenApi();
    }

    internal IResult GetWheatherForecast(HttpContext context)
    {
        // TO DO: Get data from Weather Forecast Query
        return Results.Ok();
    }
}
