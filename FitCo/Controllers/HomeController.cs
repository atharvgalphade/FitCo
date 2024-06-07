﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FitCo.Models;

namespace FitCo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Myfit()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Aboutus()
    {
        return View();
    }
    public IActionResult Profile()
    {
        return View();
    }
    public IActionResult Recipes()
    {
        return View();
    }
    public IActionResult Yoga()
    {
        return View();
    }
    public IActionResult Signup()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
