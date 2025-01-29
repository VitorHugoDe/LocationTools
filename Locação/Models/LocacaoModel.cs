using System.ComponentModel.DataAnnotations;

namespace Locação.Models
{
	public class LocacaoModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Digite o nome do Locatário!")]
		public string Locatario { get; set; }
		[Required(ErrorMessage = "Digite o nome do Locador!")]
		public string Locador { get; set; }
		[Required(ErrorMessage = "Digite o nome da Ferramenta!")]
		public string FerramentaEmprestada { get; set; }
		public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

	}
}
