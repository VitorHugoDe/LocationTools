using Locação.Data;
using Locação.Models;
using Microsoft.AspNetCore.Mvc;


namespace Locacao.Controllers
{
	public class LocacaoController : Controller
	{
		readonly private ApplicationDbContext _db;

		public LocacaoController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<LocacaoModel> locacao = _db.Locacao;
			return View(locacao);
		}

		[HttpGet]

		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Editar(int? id)
		{
			if (id == null || id == 0) {
				return NotFound();
			}
			LocacaoModel locacao = _db.Locacao.FirstOrDefault(x => x.Id == id);

			if(locacao == null)
			{
				return NotFound();
			}

			return View(locacao);
		}
		
		[HttpPost]

		public IActionResult Cadastrar(LocacaoModel locacao)
		{
			if (ModelState.IsValid)
			{
				_db.Locacao.Add(locacao);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}

			return View();
		}
	}
}
