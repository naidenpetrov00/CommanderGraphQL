namespace CommanderGraphQL.GraphQL.Commands
{
	using CommanderGraphQL.Models;
	using CommanderGraphQL.Data;

	public class CommandResolvers
	{
		[UseProjection]
		public Platform GetPlatform([Parent] Command command, AppDbContext dbContext)
		{
			return dbContext.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
		}
	}
}
