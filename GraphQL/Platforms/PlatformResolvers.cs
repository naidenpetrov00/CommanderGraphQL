namespace CommanderGraphQL.GraphQL.Platforms
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.Models;

	public class PlatformResolvers
	{
		[UseProjection]
		public IQueryable<Command> GetCommands([Parent] Platform platform, AppDbContext dbContext)
		{
			return dbContext.Commands
				.Where(c => c.PlatformId == platform.Id);
		}
	}
}
