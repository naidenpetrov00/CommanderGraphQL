namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.Models;

	using Microsoft.EntityFrameworkCore;

	public class Query
	{
		[UseFiltering]
		[UseSorting]
		public IQueryable<Platform> GetPlatform(AppDbContext dbContext)
		{
			return dbContext.Platforms;
		}

		[UseFiltering]
		[UseSorting]
		public IQueryable<Command> GetCommand(AppDbContext dbContext)
		{
			return dbContext.Commands;
		}
	}
}
