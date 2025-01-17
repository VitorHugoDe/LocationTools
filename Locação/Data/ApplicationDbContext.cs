using Locação.Models;
using Microsoft.EntityFrameworkCore;

namespace Locação.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{
			
		}

		public DbSet<LocacaoModel> Locacao { get; set; }
	}
}
