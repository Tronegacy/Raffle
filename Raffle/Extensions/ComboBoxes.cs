using Raffle.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Raffle.Extensions
{
	public static class ComboBoxes
	{
		public static void FillFromEnum<T>(this ComboBox comboBox)
		{
			var values = Enum.GetValues(typeof(T)).OfType<T>().ToArray();
			var names = Enum.GetNames(typeof(T));
			var items = names.Select((name, index) => new ComboBoxItem<T>(values[index], name)).ToArray();
			comboBox.Items.Clear();
			comboBox.Items.AddRange(items);
		}
	}
}