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
    public class ColaController : Controller
    {
         public static Queue cola = new Queue();
        public IActionResult CRUDCola(){
            return View(cola.Apuntador());
        }
        public IActionResult Equeue(){
            return View();
        }

        [HttpPost]
        public IActionResult Equeue(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen){
            cola.Equeue(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen);
            return RedirectToAction(nameof(CRUDCola));
        }
        
        public IActionResult Dequeue(){
            return View(cola.Dequeue());
        }

         public IActionResult Peek(){
            return View(cola.Peek());
        }
    }
}