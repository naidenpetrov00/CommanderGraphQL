﻿namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.GraphQL.Commands;
	using CommanderGraphQL.GraphQL.Platforms;
	using CommanderGraphQL.Models;
	using HotChocolate.Subscriptions;

	public class Mutation
	{
		public async Task<AddPlatformPayload> AddPlatformAsync(
			AddPlatformInput input,
			AppDbContext dbContext,
			[Service] ITopicEventSender eventSender,
			CancellationToken cancellationToken)
		{
			var platform = new Platform
			{
				Name = input.Name,
			};

			dbContext.Platforms.Add(platform);
			await dbContext.SaveChangesAsync();

			await eventSender.SendAsync(nameof(Subscription.OnPlatformAdded), platform);

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

		public async Task<AddPlatformPayload> AddPlatformWithCommandsAsync(AddPlatformInput platformInput, ICollection<AddCommandInputWithoutId> commandInput, AppDbContext dbContext)
		{
			var platform = new Platform { Name = platformInput.Name, };
			var commands = commandInput.Select(c => new Command
			{
				HowTo = c.HowTo,
				CommandLine = c.CommandLine,
				Platform = platform
			}).ToList();
			platform.Commands = commands;

			dbContext.Platforms.Add(platform);
			await dbContext.SaveChangesAsync();

			return new AddPlatformPayload(platform);
		}
	}
}
