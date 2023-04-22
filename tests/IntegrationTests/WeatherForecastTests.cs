using System.Net.Http.Json;

using DuongTruong.CPVM.Api;
using DuongTruong.CPVM.IntegrationTests.Fixtures;

namespace DuongTruong.CPVM.IntegrationTests;

public class WeatherForecastTests : IClassFixture<ApiAppFactory>
{
    private readonly ApiAppFactory _factory;

    public WeatherForecastTests(ApiAppFactory factory)
    {
        _factory = factory;
    }


    [Fact]
    public async Task GET_StatusOk_ReturnValidData()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/WeatherForecast");

        response.EnsureSuccessStatusCode();

        var weatherForecasts = await response.Content.ReadFromJsonAsync<IEnumerable<WeatherForecast>>();

        Assert.NotNull(weatherForecasts);
        Assert.Equal(5, weatherForecasts.Count());
    }
}
