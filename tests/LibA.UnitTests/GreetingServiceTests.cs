using LibA;

namespace LibA.UnitTests;

public class GreetingServiceTests
{
    [Test]
    public async Task CreateGreeting_WithName_ReturnsFormattedMessage()
    {
        var sut = new GreetingService();

        var result = sut.CreateGreeting("Ada");

        await Assert.That(result).IsEqualTo("Hello, Ada!");
    }

    [Test]
    public async Task CreateGreeting_WithoutName_ReturnsFallbackMessage()
    {
        var sut = new GreetingService();

        var result = sut.CreateGreeting(" ");

        await Assert.That(result).IsEqualTo("Hello!");
    }
}
