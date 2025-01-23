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

		public IActionResult Cadastrar()
		{
			return View();
		}
	}
}
