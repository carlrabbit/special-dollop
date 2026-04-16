namespace LibA;

public sealed class GreetingService
{
    public string CreateGreeting(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello!";
        }

        return $"Hello, {name}!";
    }
}
