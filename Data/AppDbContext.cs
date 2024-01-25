namespace CommanderGraphQL.Data
{
	using CommanderGraphQL.Models;

	using Microsoft.EntityFrameworkCore;

	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{

		}

        public DbSet<Platform> Platforms{ get; set; }
    }
}
