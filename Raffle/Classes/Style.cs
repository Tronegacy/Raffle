using Raffle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace Raffle.Classes
{
	public class Style
	{
		public string Name { get; }

		public Style(string name)
		{
			Name = name;
		}

		public static Style FromResourcePath(string path)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Loads scaffolder from file system path
		/// </summary>
		public static Style FromFilePath(string path)
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
			else
			{
				// wrap in col-* divs
			}

			return result.ToString();
		}

		private string RenderProperty(dsAssembly.PropertyRow prop)
		{
			if (!Templates.ContainsKey(prop.TypeName)) throw new InvalidOperationException($"No template defined for type {prop.TypeName}");

			string result = Templates[prop.TypeName];

			var variables = Regex.Match(result, "(?<!{{)({{[^{\r\n]*}})(?!{)");

			foreach (Match variable in variables.Captures)
			{
				string columnName = variable.Value.Substring(2, variable.Value.Length - 4);
				result = result.Replace(variable.Value, prop.Field<string>(columnName));
			}

			return result;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}