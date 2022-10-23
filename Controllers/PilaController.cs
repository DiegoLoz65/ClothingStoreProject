using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TiendaOnline.Models;

namespace TiendaOnline.Controllers
{
    public class PilaController : Controller
    {
        public static Stack pila = new Stack();
        public IActionResult CRUDPila(){
            
            return View(pila.Apuntador());
        }

        public IActionResult Push(){
            return View();
        }

        [HttpPost]
        public IActionResult Push(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            pila.Push(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen);
            return RedirectToAction(nameof(CRUDPila));
        }

        public IActionResult Pop(){
            return View(pila.Pop());
        }

        public IActionResult Peek(){
            return View(pila.Peek());
        }
    }
}