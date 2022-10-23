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

    public class HomeController : Controller
    {
        public static ListaEnlazada lista = new ListaEnlazada();
        public static StopWatch vector = new StopWatch();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult CRUDListas()
        {           
            return View(lista.Apuntador());
        }
        
        //GET
        public IActionResult Create()
        {
            return View();
        }
        
        //POST
        [HttpPost]
        public ActionResult Create(string pNombre, int pPrecio, string pColor, string pTalla, int pUnidades, string pImagen)
        {
            lista.Adicionar(pNombre, pPrecio, pColor, pTalla, pUnidades, pImagen);
            
         return RedirectToAction(nameof(CRUDListas));
        }

        //POST
        [HttpGet]
        public ActionResult Delete(string tmpNombre)
        {
            lista.Borrar(tmpNombre);
            
         return RedirectToAction(nameof(CRUDListas));
        }

        //POST
        [HttpPost]
        public IActionResult Search(string pNombre)
        {
            return View(lista.Search(pNombre));
        }

        [HttpGet]
        public IActionResult Details(string tmpnombre)
        {
            Console.WriteLine("llegada" + tmpnombre);
            return View(lista.Detail(tmpnombre));
        }

        public IActionResult Edit(){
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string tmpnombre, int tmpPrecio, string tmpColor, string tmpTalla, int tmpUnidades, string tmpImagen){
            lista.Editar(tmpnombre, tmpPrecio, tmpColor, tmpTalla, tmpUnidades, tmpImagen);
            return RedirectToAction(nameof(CRUDListas));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Busqueda(){
            return View();
        }
        //GET
        public IActionResult StopWatch(){
            
            return View(vector.vectoriguales());
        }

        //POST
        [HttpPost]
        public IActionResult Resultados(string pPalabra){
            return View(vector.resultados(pPalabra));
        }

        public IActionResult VectorOrd(){

            return View(vector.vectorrandomord());
        }

        public IActionResult VectorRandom(){
 
            return View(vector.vectorrandompro());
        }

        public IActionResult VectorIgual(){

            return View(vector.vectoriguales());
        }

        public IActionResult BubbleSort(){
            lista.Burbuja(lista);
            return View(lista.Apuntador());
        }

        public IActionResult BubbleSortNombre(){
            lista.Burbuja(lista); 
            return RedirectToAction(nameof(CRUDListas));
        }

        public IActionResult BubbleSortPrecio(){
            lista.BurbujaPrecio(lista); 
            return RedirectToAction(nameof(CRUDListas));
        }

        public IActionResult BubbleSortUnidades(){
            lista.BurbujaUnidades(lista); 
            return RedirectToAction(nameof(CRUDListas));
        }

        public IActionResult InsertionSort(){
            lista.Insercion(lista);
            return View(lista.Apuntador());
        }

        /*public IActionResult MergeSort(){
            ListaEnlazada ordenada = lista.MergeSort(lista);
            return View(ordenada.Apuntador());
        }*/

        public IActionResult QuickSort(){
            lista.QuickSort(0, lista.Cantidad() - 1, lista);
            return View(lista.Apuntador());
        }

        public IActionResult Shop(){
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
