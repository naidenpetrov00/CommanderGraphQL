namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.Models;
	using Microsoft.EntityFrameworkCore;

	public class Query
	{
		public IQueryable<Platform> GetPlatform([Service] AppDbContext dbContext)
		{
			return dbContext.Platforms.AsNoTracking();
		}
	}
}
