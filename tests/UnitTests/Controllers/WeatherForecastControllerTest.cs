using DuongTruong.CPVM.Api.Controllers;

using Microsoft.Extensions.Logging;

namespace DuongTruong.CPVM.UnitTests.Controllers;

public class WeatherForecastControllerTest
{
    [Fact]
    public void Given_NoInput_Return_WeatherForeCastEnumerable()
    {
        var mockLogger = new Mock<ILogger<WeatherForecastController>>();

        var controller = new WeatherForecastController(mockLogger.Object);

        var forecast = controller.Get();

        Assert.NotEmpty(forecast);
    }
}
