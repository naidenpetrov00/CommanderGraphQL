using System.ComponentModel.DataAnnotations;

namespace CommanderGraphQL.Models
{
	public class Platform
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string LicenseKey { get; set; }
	}
}
