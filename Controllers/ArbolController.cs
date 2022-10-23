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
    public class ArbolController : Controller
    {
        public static Arbol arbol = new Arbol();
        NodoArbol raiz = arbol.Insertar("RAIZ", 1000, "RAIZ", "RAIZ",  1000, "RAIZ", null);
        
        public static producto3[] tmp = new producto3[1000];
        
        public IActionResult CRUDArbol()
        {           
            producto3[] apuntador = new producto3[1000];
            tmp=apuntador;
            return View(arbol.ApuntadorPreOrden(raiz, apuntador));
        }

        public IActionResult CreateArbol()
        {
            return View();
        }
        
        //POST
        [HttpPost]
        public ActionResult CreateArbol(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen)
        {
            arbol.Insertar(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen, raiz);
            
         return RedirectToAction(nameof(CRUDArbol));
        }

        [HttpPost]
        public IActionResult SearchArbol(string pNombre)
        {
            return View(arbol.Search(pNombre, tmp));
        }

        [HttpGet]
        public IActionResult DetailsArbol(string tmpnombre)
        {
            return View(arbol.Search(tmpnombre, tmp));
        }

        public IActionResult EditArbol(){
            return View();
        }

        [HttpPost]
        public IActionResult EditArbol(string tmpnombre, int tmpPrecio, string tmpColor, string tmpTalla, int tmpUnidades, string tmpImagen){
            arbol.Edit(tmpnombre, tmpPrecio, tmpColor, tmpTalla, tmpUnidades, tmpImagen, raiz);
            
            return RedirectToAction(nameof(CRUDArbol));
        }
    }
}
