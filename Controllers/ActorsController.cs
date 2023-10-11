using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using movies.Data;
using movies.DataAccess.Services;
using movies.Models;

namespace movies.Controllers;

public class ActorsController : Controller
{

    private readonly IActorsService _service;

    public ActorsController(IActorsService service)
    {
        _service = service;
    }
    public async Task<IActionResult> Index()
    {
        var allActors = await _service.GetAll();
        return View(allActors);
    }

    //Get:Actors/Create
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]

    public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")] Actor actor)
    {
        await _service.AddAsync(actor);
        TempData["success"]="Actor created Successfully";
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if(actorDetails == null)
            return View("Empty");
        return View(actorDetails);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if(actorDetails == null)
            return View("Empty");
        return View(actorDetails);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var actorDetails = await _service.GetByIdAsync(id);
        if(actorDetails == null)
            return View("NotFound");
        return View(actorDetails);
    }
    [HttpPost]

    public async Task<IActionResult> Edit(int id, Actor actor)
    {
        await _service.UpdateAsync(actor);
        TempData["success"]="Actor Edited Successfully";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]

    public IActionResult Delete(Actor actor)
    {
        _service.Delete(actor);
        TempData["success"]="Actor Deleted Successfully";
        return RedirectToAction(nameof(Index));
    }
}