using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp_sessions.Models;

namespace tp_sessions.Controllers;

public class SessionController : Controller
{
        public IActionResult Index()
    {
        return View();
    }
}