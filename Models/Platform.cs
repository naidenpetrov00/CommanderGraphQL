namespace CommanderGraphQL.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Platform
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string? LicenseKey { get; set; }

		public ICollection<Command> Commands => new HashSet<Command>();
	}
}
