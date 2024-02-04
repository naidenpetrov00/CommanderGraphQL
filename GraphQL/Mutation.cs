namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.GraphQL.Commands;
	using CommanderGraphQL.GraphQL.Platforms;
	using CommanderGraphQL.Models;

	public class Mutation
	{
		public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input, AppDbContext dbContext)
		{
			var platform = new Platform
			{
				Name = input.Name,
			};

			dbContext.Platforms.Add(platform);
			await dbContext.SaveChangesAsync();

			return new AddPlatformPayload(platform);
		}

		public async Task<AddCommandPayload> AddCommandAsync(AddCommandInput input, AppDbContext dbContext)
		{
			var command = new Command
			{
				HowTo = input.HowTo,
				CommandLine = input.CommandLine,
				PlatformId = input.PlatformId,
			};

			dbContext.Commands.Add(command);
			await dbContext.SaveChangesAsync();

			return new AddCommandPayload(command);
		}
	}
}
