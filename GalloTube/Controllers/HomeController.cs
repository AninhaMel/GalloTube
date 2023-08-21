using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GalloTube.Models;
using GalloTube.Interfaces;


namespace GalloTube.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IVideoRepository _movieRepository;

    public HomeController(ILogger<HomeController> logger, IVideoRepository videoRepository)
    {
        _logger = logger;
        _movieRepository = VideoRepository;
    }

    public IActionResult Index()
    {
        var movies = _VideoRepository.ReadAll();
        return View(Videos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogError("Ocorreu um erro");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}