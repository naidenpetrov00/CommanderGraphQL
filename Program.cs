namespace CommanderGraphQL
{
	public class Program
	{
		private readonly IConfiguration configuration;

		public Program(IConfiguration configuration)
        {
			this.configuration = configuration;
		}

        public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var app = builder.Build();

			app.MapGet("/", () => "Hello World!");

			app.Run();
		}
	}
}
