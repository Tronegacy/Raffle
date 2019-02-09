using Raffle.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raffle.Classes
{
	public class FormScaffolder
	{
		public static FormScaffolder FromResourcePath(string path)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Loads scaffolder from file system path
		/// </summary>
		public static FormScaffolder FromFilePath(string path)
		{
			throw new NotImplementedException();
		}

		public Dictionary<string, string> Templates { get; set; }

		/// <summary>
		/// Generate HTML for the selected properties
		/// </summary>
		public string Render(dsAssembly.PropertyRow[] properties, int fieldsPerRow = 1)
		{
			StringBuilder result = new StringBuilder();

			if (12 % fieldsPerRow != 0 || fieldsPerRow > 12 || fieldsPerRow < 1)
			{
				throw new ArgumentException($"fieldsPerRow argument {fieldsPerRow} must be divide evenly into 12, and be between 1 and 12");
			}

			if (fieldsPerRow == 1)
			{
				foreach (var prop in properties) result.AppendLine(RenderProperty(prop));
			}

			return result.ToString();
		}

		private string RenderProperty(dsAssembly.PropertyRow prop)
		{
			throw new NotImplementedException();
		}
	}
}