using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies.DataAccess;
using movies.Models;

namespace movies.Controllers;

public class MoviesController : Controller
{
    
    private readonly AppDbContext _context;

    public MoviesController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var _allMovies = await _context.Movies.Include(n=>n.Cinema).ToListAsync();
        return View(_allMovies);
    }
}