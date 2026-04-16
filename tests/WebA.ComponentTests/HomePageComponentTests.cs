using WebA.Components.Pages;

namespace WebA.ComponentTests;

public class HomePageComponentTests : Bunit.BunitContext
{
    [Test]
    public async Task HomePage_RendersWelcomeText()
    {
        var component = Render<Home>();

        var hasWelcomeText = component.Markup.Contains("Welcome to your new app.", StringComparison.Ordinal);

        await Assert.That(hasWelcomeText).IsTrue();
    }
}
