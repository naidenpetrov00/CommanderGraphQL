namespace CommanderGraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.GraphQL;
	using Microsoft.EntityFrameworkCore;

	using global::GraphQL.Server.Ui.Voyager;
	using CommanderGraphQL.GraphQL.Platforms;
	using CommanderGraphQL.GraphQL.Commands;

	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")
				));

			builder.Services
				.AddGraphQLServer()
				.RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
				.AddQueryType<Query>()
				.AddMutationType<Mutation>()
				.AddType<PlatformType>()
				.AddType<CommandType>()
				.AddFiltering()
				.AddSorting()
				.AddProjections();

			var app = builder.Build();

			app.MapGraphQL();
			app.UseGraphQLVoyager("/graphql-voyager", new VoyagerOptions()
			{
				GraphQLEndPoint = "/graphql",
			});

			app.Run();
		}
	}
}
