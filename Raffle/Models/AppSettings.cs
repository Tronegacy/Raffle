using JsonSettings;
using System.Windows.Forms;

namespace Raffle.Models
{
	public class AppSettings : JsonSettingsBase
	{
		public string AssemblyFile { get; set; }
		public Orientation SplitterOrientation { get; set; }
		public string Style { get; set; }

		public override Scope Scope => Scope.User;
		public override string CompanyName => "Adam O'Neil";
		public override string ProductName => "Raffle";
		public override string Filename => "Settings.json";
	}
}