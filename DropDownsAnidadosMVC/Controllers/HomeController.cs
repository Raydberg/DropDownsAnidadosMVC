using DropDownsAnidadosMVC.Datos;
using DropDownsAnidadosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DropDownsAnidadosMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _contexto;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var sucursales = _contexto.Sucursal.ToList();
            var vm = new DropDownsVM
            { Sucursales = sucursales };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public JsonResult ObtenerCategorias(int sucursalID)
        {
            var categorias = _contexto.Categoria.Where(c=>c.SucursalId == sucursalID).ToList();
            return Json(categorias);
        }

        [HttpGet]
        public JsonResult ObtenerProductos(int categoriaID)
        {
            var productos = _contexto.Producto.Where(p => p.CategoriaId == categoriaID).ToList();
            return Json(productos);
        }

    }
}
