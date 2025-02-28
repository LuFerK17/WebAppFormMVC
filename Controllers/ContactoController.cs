using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using WebAppFormMVC.Models;

namespace WebAppFormMVC.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ContactoR _contactoRepository;

        public ContactoController(ContactoR contactoRepository)
        {
            _contactoRepository = contactoRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                _contactoRepository.GuardarContacto(contacto);
                ViewBag.Mensaje = "Datos guardados correctamente.";
                return View();
            }
            return View(contacto);
        }
    }
}
