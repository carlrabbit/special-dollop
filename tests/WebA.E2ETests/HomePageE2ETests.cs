using Microsoft.Playwright;

namespace WebA.E2ETests;

public class HomePageE2ETests
{
    [Test]
    public async Task PlaywrightDependency_IsAvailableForE2ETests()
    {
        var launchOptions = new BrowserTypeLaunchOptions { Headless = true };

        await Assert.That(launchOptions.Headless).IsTrue();
        await Assert.That(typeof(IPage).Namespace).IsEqualTo("Microsoft.Playwright");
    }
}
