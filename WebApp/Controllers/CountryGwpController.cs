using Microsoft.AspNetCore.Mvc;
using WebApp.Api.Service;
using WebApp.Api.ServiceInterface;
using WebApp.Models;

namespace WebApp.Controllers;

[ApiController]
[Route("server/api/gwp")]
public class CountryGwpController : ControllerBase
{
    private IGwpAvgService _IGwpAvgService;
    public CountryGwpController(IGwpAvgService gwpAvgService)
    {
        _IGwpAvgService = gwpAvgService;
    }

    [HttpPost]
    [Route("avg")]
    public IActionResult Post([FromBody] GwpAvgModel model)
    {
        var result = _IGwpAvgService.GetGwpAvg(model);
        return Ok(result);
    }
}

