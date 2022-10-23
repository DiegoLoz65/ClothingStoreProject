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
    public class VectorController : Controller
    {
        public static Vector vector = new Vector();
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult CRUDVector()
        {   
            return View(vector.Apuntador());
        }

        public IActionResult CreateVector()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult CreateVector(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen)
        {
            vector.Adicionar(pNombre,  pPrecio, pColor, pTalla, pUnidades, pImagen);
            
         return RedirectToAction(nameof(CRUDVector));
        }

        [HttpGet]
        public IActionResult DetailsVector(string tmpnombre)
        {
            Console.WriteLine("llegada" + tmpnombre);
            return View(vector.Detail(tmpnombre));
        }

        public IActionResult EditVector(){
            return View();
        }

        [HttpPost]
        public IActionResult EditVector(string tmpnombre, int tmpPrecio, string tmpColor, string tmpTalla, int tmpUnidades, string tmpImagen){
            Console.WriteLine("Llegada" + tmpnombre);
            vector.Editar(tmpnombre, tmpPrecio, tmpColor, tmpTalla, tmpUnidades, tmpImagen);
            return RedirectToAction(nameof(CRUDVector));
        }

        [HttpGet]
        public ActionResult DeleteVector(string tmpNombre)
        {
            vector.Eliminar(tmpNombre);
            
         return RedirectToAction(nameof(CRUDVector));
        }

        [HttpPost]
        public IActionResult SearchVector(string pNombre)
        {
            
            return View(vector.Search(pNombre));
        }
    }
}