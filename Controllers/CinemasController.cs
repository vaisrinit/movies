using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies.DataAccess;
using movies.Models;

namespace movies.Controllers;

public class CinemasController : Controller
{
    
    private readonly AppDbContext _context;

    public CinemasController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var _allCinemas = await _context.Cinemas.ToListAsync();
        return View(_allCinemas);
    }
}