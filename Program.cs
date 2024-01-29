namespace CommanderGraphQL
{
	using CommanderGraphQL.Data;
	using CommanderGraphQL.GraphQL;

	using Microsoft.EntityFrameworkCore;

	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")
				));

			builder.Services
				.AddGraphQLServer()
				.AddQueryType<Query>();

			var app = builder.Build();

			app.MapGraphQL(); 

			app.Run();
		}
	}
}
