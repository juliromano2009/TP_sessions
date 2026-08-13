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

    //haceme un iactionresult que me permita iniciar sesion, chequee que el usuario exista y que la contraseña sea correcta, si es asi me 
    // lleve a la pagina de inicio, si nom existe el usuario o la contraseña es incorrecta que me devuelva 
    // a la pagina de inicio de sesion con un mensaje de error
    [HttpPost]
    public IActionResult IniciarSesion(string nombreUsuario, string contraseña)
    {
        BD bd = new BD();
        Usuario usuario = bd.ObtenerUsuario(nombreUsuario, contraseña);

        if (usuario != null)
        {
            // El usuario existe y la contraseña es correcta
            // Redirigir a la página de inicio
            return ("Bienvenida");
        }
        else
        {
            // El usuario no existe o la contraseña es incorrecta
            // Devolver a la página de inicio de sesión con un mensaje de error
            ViewBag.ErrorMessage = "Nombre de usuario o contraseña incorrectos.";
            return View("Index");
        }
    }

}