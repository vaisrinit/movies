using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies.DataAccess;
using movies.DataAccess.Services;
using movies.Models;

namespace movies.Controllers;

public class ProducersController : Controller
{
    
    private readonly IProducersService _service;

    public ProducersController(IProducersService service)
    {
        _service = service;
    }
    public async Task<IActionResult> Index()
    {
        var _allProducers = await _service.GetAll();
        return View(_allProducers);
    }
}