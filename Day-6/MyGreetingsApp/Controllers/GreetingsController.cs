using System;
using Microsoft.AspNetCore.Mvc;
using MyGreetingsApp.Models;

namespace MyGreetingsApp.Controllers;

public class GreetingsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Greeting greeting)
        {
            greeting.Message = $"Hello, {greeting.Name}!";

            return View(greeting);
        }
}
