using Microsoft.AspNetCore.Mvc;

namespace UnitTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    public WeatherForecastController()
    {

    }

    [HttpGet("Get")]
    public void Get()
    {
        return;
    }
}
