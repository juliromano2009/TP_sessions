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
    
    //haceme un iactionresult que me lleve a registrarse.cshtml
    public IActionResult Registrarse()
    {
        return View();
    }
}