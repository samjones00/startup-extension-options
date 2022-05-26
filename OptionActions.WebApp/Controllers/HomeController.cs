using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionActions.WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly IOptions<ServiceOptions> _options;

    public HomeController(IOptions<ServiceOptions> options)
    {
        _options = options;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_options.Value);
    }
}
