using Agendamento.Models;
using Agendamento.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agendamento.Controllers
{
    public class MedicoController : Controller
    {
        private readonly MedicoService _medicoService;

        public MedicoController(MedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        public IActionResult Index()
        {
            return View(_medicoService.Listar());
        }

        public IActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Inserir(Medico medico)
        {
            if (!ModelState.IsValid) return View(medico);

            _medicoService.Inserir(medico);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhar(int? id)
        {
            if (id == null) return NotFound();

            var obj = _medicoService.EncontrarId(id.Value);
            if (obj == null) return NotFound();

            return View(obj);
        }

        public IActionResult Editar(int? id)
        {
            if (id == null) return NotFound();

            var obj = _medicoService.EncontrarId(id.Value);
            if (obj == null) return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Medico medico)
        {
            if (!ModelState.IsValid) return View(medico);

            _medicoService.Atualizar(medico);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remover(int? id)
        {
            if (id == null) return NotFound();

            var obj = _medicoService.EncontrarId(id.Value);
            if (obj == null) return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remover(int id)
        {
            _medicoService.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
