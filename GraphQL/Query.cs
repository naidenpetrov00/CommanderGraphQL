namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.Models;

	using Microsoft.EntityFrameworkCore;

	public class Query
	{
		[UseProjection]
		public IQueryable<Platform> GetPlatform(AppDbContext dbContext)
		{
			return dbContext.Platforms;
		}

		[UseProjection]
		public IQueryable<Command> GetCommand(AppDbContext dbContext)
		{
			return dbContext.Commands;
		}
	}
}
