namespace CommanderGraphQL.Models
{
	using System.ComponentModel.DataAnnotations;

	[GraphQLDescription("Represents any software or service that has a command line interface.")]
	public class Command
	{
		public int Id { get; set; }

		[Required]
		public string HowTo { get; set; }

		[Required]
		public string CommandLine { get; set; }

		[Required]
		public int PlatformId { get; set; }

		public Platform Platform { get; set; }
	}
}
