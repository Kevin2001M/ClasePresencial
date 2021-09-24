using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Models;

namespace Usuarios.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }
            else
            {
                return View("Index", usuario);
            }

        }

        public IActionResult Registro()
        {
            return View();
        }

    }
}
