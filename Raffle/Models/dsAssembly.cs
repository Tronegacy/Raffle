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
			foreach (var t in types)
			{
				var typeRow = result.Type.AddTypeRow(t.FullName);
				var props = t.GetProperties().Where(p => p.CanWrite && p.CanRead);
				foreach (var p in props)
				{
					var prop = result.Property.NewPropertyRow();
					prop.TypeId = typeRow.Id;
					prop.PropertyName = p.Name;
					prop.TypeName = p.PropertyType.Name;
					result.Property.Rows.Add(prop);
				}
			}

			return result;
		}
	}
}
