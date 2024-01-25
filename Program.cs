using CommanderGraphQL.Data;
using Microsoft.EntityFrameworkCore;

namespace CommanderGraphQL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")
				));

			var app = builder.Build();

			app.MapGet("/", () => "Hello World!");

			app.Run();
		}
	}
}
