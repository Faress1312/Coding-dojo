using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionLecture.Models;
//! Session Config Part 3
using Microsoft.AspNetCore.Http;
// :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::



namespace SessionLecture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HttpContext.Session.SetInt32("age",36);
        HttpContext.Session.SetString("username","john");

        return View();
    }
[HttpPost("user/create")]
public IActionResult CreateUser(string username , int age , string favSport)
{
    System.Console.WriteLine($"Username: {username}\n age : {age}\n favSport : {favSport}");
}
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

