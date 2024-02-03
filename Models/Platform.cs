namespace CommanderGraphQL.Models
{
	using System.ComponentModel.DataAnnotations;

	[GraphQLDescription("Represents any software or service that has a command line interface.")]
	public class Platform
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string? LicenseKey { get; set; }

		public ICollection<Command> Commands { get; set; } = new List<Command>();
	}
}
