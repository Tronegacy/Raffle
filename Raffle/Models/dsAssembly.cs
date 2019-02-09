using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.Linq;
using System.Reflection;

namespace Raffle.Models
{
	partial class dsAssembly
	{
		public static dsAssembly FromAssembly(string fileName)
		{
			dsAssembly result = new dsAssembly();

			var assembly = Assembly.LoadFrom(fileName);

			var types = assembly.GetExportedTypes();

			using (var provider = new CSharpCodeProvider())
			{
				foreach (var t in types)
				{
					var typeRow = result.Type.AddTypeRow(t.FullName);
					var props = t.GetProperties().Where(p => p.CanWrite && p.CanRead);
					foreach (var p in props)
					{
						var prop = result.Property.NewPropertyRow();
						prop.TypeId = typeRow.Id;
						prop.PropertyName = p.Name;
						prop.TypeName = CSharpTypeName(provider, p.PropertyType);
						prop.IsNullable = IsNullableGeneric(p.PropertyType);
						result.Property.Rows.Add(prop);
					}
				}
			}

			return result;
		}

		public partial class TypeRow
		{
			public string ShortName
			{
				get { return FullName.Split('.').Last(); }
			}
		}

		public partial class PropertyRow
		{
			public string CSharpSyntax
			{
				get
				{
					string result = $"public {TypeName}";
					if (IsNullable) result += "?";
					result += $" {PropertyName} {{ get; set; }}";
					return result;
				}
			}
		}

		/// <summary>
		/// From https://github.com/adamosoftware/Postulate.Zinger/blob/master/Zinger/Models/QueryProvider.cs#L253
		/// </summary>
		private static string CSharpTypeName(CSharpCodeProvider provider, Type type)
		{
			if (IsNullableGeneric(type))
			{
				return CSharpTypeName(provider, type.GetGenericArguments()[0]);
			}

			CodeTypeReference typeRef = new CodeTypeReference(type);
			return provider.GetTypeOutput(typeRef).Replace("System.", string.Empty);
		}

		private static bool IsNullableGeneric(Type type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
	}
}
