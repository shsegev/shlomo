using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using ASP.NETCore4shlomo.Models;

namespace ASP.NETCore4shlomo.Controllers;

public class BackendController : Controller
{
    private readonly ILogger<BackendController> _logger;

    public BackendController(ILogger<BackendController> logger)
    {
        _logger = logger;
    }
    
}