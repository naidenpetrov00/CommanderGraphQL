namespace CommanderGraphQL.GraphQL.Commands
{
	using CommanderGraphQL.Models;

	public class CommandType : ObjectType<Command>
	{
		protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
		{
			descriptor
				.Field(c => c.Platform)
				.ResolveWith<CommandResolvers>(c => c.GetPlatform(default!, default!));
		}
	}
}
