using Raffle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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

		public static IEnumerable<Style> FromResourcePath(string path)
		{
			var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames()
				.Where(r => r.StartsWith(path))
				.Select(r => r.Substring(path.Length)).ToArray();

			var styleGroups = StyleGroupsFromItems(resources, new char[] { '.' });

			return styleGroups.Select(grp =>
			{
				var result = new Style(grp.Key);
				result.Templates = LoadTemplates(path, new char[] { '.' }, grp, (item, typeName, dictionary) =>
				{
					using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(path + item))
					{
						using (var reader = new StreamReader(resource))
						{
							string content = reader.ReadToEnd();
							dictionary.Add(typeName, content);
						}
					}
				});
				return result;
			});
		}

		/// <summary>
		/// Loads scaffolder from file system path
		/// </summary>
		public static IEnumerable<Style> FromFilePath(string path)
		{
			if (!Directory.Exists(path)) return Enumerable.Empty<Style>();

			string[] fileNames = Directory.GetFiles(path, "*.html", SearchOption.AllDirectories);

			var styleGroups = StyleGroupsFromItems(fileNames, new char[] { '\\', '.' });

			return styleGroups.Select(grp =>
			{
				var result = new Style(grp.Key);
				result.Templates = LoadTemplates(path, new char[] { '\\', '.' }, grp, (item, typeName, dictionary) =>
				{
					using (var file = File.OpenText(item))
					{
						string content = file.ReadToEnd();
						dictionary.Add(typeName, content);
					}
				});
				return result;
			});

		}

		private static IEnumerable<IGrouping<string, string>> StyleGroupsFromItems(string[] items, char[] pathSeparators)
		{
			return items.GroupBy(name =>
			{
				string[] parts = name.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);
				return parts[parts.Length - 3];
			});
		}

		private static Dictionary<string, string> LoadTemplates(string path, char[] pathSeparators, IGrouping<string, string> styleGroup, Action<string, string, Dictionary<string, string>> addToDictionary)
		{
			Dictionary<string, string> results = new Dictionary<string, string>();

			foreach (var item in styleGroup)
			{
				var parts = item.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);
				string typeName = parts[parts.Length - 2]; // the type name is assumed to be the name before th extention (i.e. bool.html)
				addToDictionary.Invoke(item, typeName, results);
			}

			return results;
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