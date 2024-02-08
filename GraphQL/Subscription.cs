namespace CommanderGraphQL.GraphQL
{
	using CommanderGraphQL.Models;

	public class Subscription
	{
		[Subscribe]
		[Topic]
		public Platform OnPlatformAdded([EventMessage] Platform platform)
			=> platform;
	}
}
