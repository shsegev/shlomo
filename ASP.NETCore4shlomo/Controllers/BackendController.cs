namespace ASP.NETCore4shlomo.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

[Route("api/[controller]")]
[ApiController]
public class BackendController: Controller
{
    [HttpGet]
    public async Task<ActionResult> GetChartData()
    {
        try
        {
            return Ok("{\"data\": \"ok\"}");
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "oops");
        }
    }

}