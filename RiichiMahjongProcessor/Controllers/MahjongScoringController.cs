using Microsoft.AspNetCore.Mvc;

namespace RiichiMahjongProcessor.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MahjongScoringController : ControllerBase
{
    [HttpPost("CalculateHandValue")]
    public IActionResult CalculateHandValue()
    {
        // For now, just return OK
        return Ok();
    }
}