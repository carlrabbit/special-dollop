using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SvcA.IntegrationTests;

public class GreetingEndpointTests
{
    [Test]
    public async Task GetGreeting_ReturnsConfiguredGreetingMessage()
    {
        await using var appFactory = new WebApplicationFactory<Program>();
        using var client = appFactory.CreateClient();

        var payload = await client.GetFromJsonAsync<GreetingResponsePayload>("/greeting");

        await Assert.That(payload is not null).IsTrue();
        await Assert.That(payload!.Message).IsEqualTo("Hello, from LibA!");
    }

    private sealed record GreetingResponsePayload(string Message);
}
