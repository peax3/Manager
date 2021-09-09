using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<Issue> Issues { get; set; }
	}
}