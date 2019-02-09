using JsonSettings;

namespace Raffle.Models
{
	public class AppSettings : JsonSettingsBase
	{
		public string AssemblyFile { get; set; }

		public override Scope Scope => Scope.User;
		public override string CompanyName => "Adam O'Neil";
		public override string ProductName => "Raffle";
		public override string Filename => "Settings.json";
	}
}