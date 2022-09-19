using LecConsumeWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LecConsumeWebAPI.Controllers;

public class PetController : Controller
{
    private readonly IPetRepository _petRepo;

    public PetController(IPetRepository petRepo)
    {
        _petRepo = petRepo;
    }

    public async Task<IActionResult> Index()
    {
        var pets = await _petRepo.ReadAllAsync();
        return View(pets);
    }
}
