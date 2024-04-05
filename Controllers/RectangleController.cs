using Microsoft.AspNetCore.Mvc;
using RectangleAPI.Models;
using RectangleAPI.Services;

[ApiController]
[Route("[controller]")]
public class RectangleController : ControllerBase
{
    [HttpGet("dimensions")]
    public ActionResult<Rectangle> GetInitialDimensions()
    {
        var initialDimensions = JsonService.GetInitialDimensions();
        return Ok(initialDimensions);
    }

    [HttpPut("dimensions")]
    public IActionResult UpdateDimensions(Rectangle rectangle)
    {
        JsonService.UpdateDimensions(rectangle);
        return Ok();
    }
}
