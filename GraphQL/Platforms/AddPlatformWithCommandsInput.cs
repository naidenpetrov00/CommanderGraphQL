using CommanderGraphQL.GraphQL.Commands;

namespace CommanderGraphQL.GraphQL.Platforms
{
	public record AddPlatformWithCommandsInput(AddPlatformInput Platform, ICollection<AddCommandInput> Commands)
	{
	}
}