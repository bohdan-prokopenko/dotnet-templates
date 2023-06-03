using MiniApi.Responses;
using Microsoft.AspNetCore.Authorization;

namespace MiniApi.Endpoints;

[HttpGet("/hello"), AllowAnonymous]
public class HelloEndpoint : EndpointWithoutRequest<HelloResponse>
{
    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync(new HelloResponse() { }, 200, ct);
    }
}