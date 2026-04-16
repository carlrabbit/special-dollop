# Testing Guide for the .NET 10 Solution

This solution uses:

- `src/LibA` for reusable domain logic
- `src/SvcA` for the Minimal Web API
- `src/WebA` for the Blazor web app (server interactivity)
- `tests/*` for all test projects

## Test project structure

Use one test project per test type and target component:

- `tests/LibA.UnitTests` → fast, isolated unit tests for `LibA`
- `tests/SvcA.IntegrationTests` → API integration tests for `SvcA`
- `tests/WebA.ComponentTests` → bUnit component tests for `WebA`
- `tests/WebA.E2ETests` → Playwright E2E tests for user journeys

## Naming conventions

### Project names

`<TargetProject>.<TestType>Tests`

Examples:

- `LibA.UnitTests`
- `SvcA.IntegrationTests`
- `WebA.ComponentTests`
- `WebA.E2ETests`

### Test class names

`<FeatureOrEndpoint>Tests`

Examples:

- `GreetingServiceTests`
- `GreetingEndpointTests`
- `HomePageComponentTests`
- `HomePageE2ETests`

### Test method names

`<MethodOrBehavior>_<Scenario>_<ExpectedResult>`

Examples:

- `CreateGreeting_WithName_ReturnsFormattedMessage`
- `GetGreeting_ReturnsConfiguredGreetingMessage`
- `HomePage_RendersWelcomeText`

## Writing tests by type

### Unit tests (TUnit)

- Keep dependencies in-memory.
- Test one behavior at a time.
- Cover happy path and guard/edge cases.

### Integration tests (TUnit + `WebApplicationFactory`)

- Boot the API in-process.
- Call real HTTP endpoints.
- Assert response shape and important values.

### Blazor component tests (TUnit + bUnit)

- Render components with `TestContext`.
- Assert rendered HTML and behavior.
- Keep test assertions focused on user-visible output.

### E2E tests (TUnit + Playwright)

- Use Playwright for browser-based scenarios.
- Prefer page-object style for larger suites.
- Keep smoke tests stable and deterministic.

## Suggested command order

```bash
dotnet restore SpecialDollop.sln
dotnet build SpecialDollop.sln
dotnet test SpecialDollop.sln
```
