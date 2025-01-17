namespace Locação.Models
{
	public class LocacaoModel
	{
		public int Id { get; set; }
		public string Locatario { get; set; }
		public string Locador { get; set; }
		public string FerramentaEmprestada { get; set; }
		public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

	}
}
