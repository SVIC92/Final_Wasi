using EF_DAS_GRUPO1.Datos;
using EF_DAS_GRUPO1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EF_DAS_GRUPO1.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Crear(Productos producto)
        {
            if (ModelState.IsValid)
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);

        }

        [Authorize]
        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Productos.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Productos producto)
        {
            if (ModelState.IsValid)
            {
                _db.Productos.Update(producto);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        [Authorize]
        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Productos.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Productos producto)
        {
            if (producto == null)
            {
                return NotFound();
            }
            _db.Productos.Remove(producto);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

    }
}
