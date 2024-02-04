namespace CommanderGraphQL.GraphQL.Platforms
{
	using CommanderGraphQL.Models;

	public class PlatformType : ObjectType<Platform>
	{
		protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
		{
			descriptor
				.Field(p => p.Commands)
				.ResolveWith<PlatformResolvers>(p => p.GetCommands(default!, default!));
		}
	}
}
