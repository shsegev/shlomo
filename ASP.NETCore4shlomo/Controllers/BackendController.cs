namespace ASP.NETCore4shlomo.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

[Route("api/[controller]")]
[ApiController]
public class BackendController: Controller
{
    [HttpGet]
    public IActionResult GetChartData()
    {
        try
        {
            var response = new Dictionary<string, List<int>>
            {
                {"data", new List<int> {28, 48, 40, 19, 86, 27, 90}}
            };
            return new JsonResult(response);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "oops");
        }
    }

}