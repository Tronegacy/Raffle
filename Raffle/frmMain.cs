using JsonSettings;
using Raffle.Classes;
using Raffle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Raffle
{
	public partial class frmMain : Form
	{
		private AppSettings _settings = null;
		private dsAssembly _assembly = null;
		private Style[] _styles = null;

		public frmMain()
		{
			InitializeComponent();
			dgvTypes.AutoGenerateColumns = false;
			dgvProperties.AutoGenerateColumns = false;
		}

		private void tbAssembly_BuilderClicked(object sender, Controls.BuilderEventArgs e)
		{
			if (tbAssembly.SelectFile("Assemblies|*.dll;*.exe|All Files|*.*", e))
			{
				_assembly = dsAssembly.FromAssembly(e.Result);
				InitDataGrids();
			}
		}

		private void InitDataGrids()
		{
			BindingSource bsTypes = new BindingSource();
			bsTypes.DataSource = _assembly.Type;
			dgvTypes.DataSource = bsTypes;

			BindingSource bsProps = new BindingSource();
			bsProps.DataSource = bsTypes;
			bsProps.DataMember = "FK_Type_Property";
			dgvProperties.DataSource = bsProps;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			_settings = JsonSettingsBase.Load<AppSettings>();
			_styles = LoadStyles();

			cbStyle.Items.AddRange(_styles);
			FillComboBox<Orientation>(cbOrientation);

			LoadFields();
			InitDataBinding();
						
			if (File.Exists(tbAssembly.Text))
			{
				_assembly = dsAssembly.FromAssembly(tbAssembly.Text);
				InitDataGrids();
			}
		}

		private void FillComboBox<T>(ComboBox comboBox)
		{
			var values = Enum.GetValues(typeof(T)).OfType<T>().ToArray();
			var names = Enum.GetNames(typeof(T));
			var items = names.Select((name, index) => new ComboBoxItem<T>(values[index], name)).ToArray();
			comboBox.Items.Clear();
			comboBox.Items.AddRange(items);
		}

		private Style[] LoadStyles()
		{
			List<Style> results = new List<Style>();

			results.AddRange(GetStylesFromResources("Raffle.Styles"));

			return results.ToArray();
		}

		private IEnumerable<Style> GetStylesFromResources(string resourcePath)
		{
			var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames()
				.Where(r => r.StartsWith(resourcePath))
				.Select(r => r.Substring(resourcePath.Length)).ToArray();

			var styles = resources.GroupBy(name =>
			{
				string[] parts = name.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
				return parts[0];
			});

			return styles.Select(grp =>
			{
				var result = new Style(grp.Key);
				result.Templates = LoadResourceTemplates(resourcePath, grp);
				return result;
			});			
		}

		private Dictionary<string, string> LoadResourceTemplates(string path, IGrouping<string, string> grp)
		{
			Dictionary<string, string> results = new Dictionary<string, string>();

			foreach (var item in grp)
			{
				var parts = item.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
				string typeName = parts[parts.Length - 2]; // the type name is assumed to be the name before th extention (i.e. bool.html)
				using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(path + item))
				{
					using (var reader = new StreamReader(resource))
					{
						string content = reader.ReadToEnd();
						results.Add(typeName, content);
					}
				}
			}

			return results;
		}

		private void LoadFields()
		{
			tbAssembly.Text = _settings.AssemblyFile;
			cbStyle.SelectedIndex = cbStyle.FindString(_settings.Style);
			cbOrientation.SelectedIndex = cbOrientation.FindString(_settings.SplitterOrientation.ToString());
			splitContainer1.Orientation = _settings.SplitterOrientation;
		}

		private void InitDataBinding()
		{
			tbAssembly.TextChanged += delegate (object sender, EventArgs e) { _settings.AssemblyFile = tbAssembly.Text; };

			cbOrientation.SelectedIndexChanged += delegate (object sender, EventArgs e) 
			{
				var value = ((ComboBoxItem<Orientation>)cbOrientation.SelectedItem).Value;
				_settings.SplitterOrientation = value;
				splitContainer1.Orientation = value;
			};

			cbStyle.SelectedIndexChanged += delegate (object sender, EventArgs e) { _settings.Style = (cbStyle.SelectedItem as Style)?.Name; };
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			_settings.Save();
		}

		private void tbTypeFilter_TextChanged(object sender, EventArgs e)
		{
			string filter = tbTypeFilter.Text;
			(dgvTypes.DataSource as BindingSource).Filter = (!string.IsNullOrEmpty(filter)) ?
				$"[FullName] LIKE '%{tbTypeFilter.Text}%'" :
				null;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			var style = cbStyle.SelectedItem as Style;
			if (style == null)
			{
				MessageBox.Show("No style selected.");
				return;
			}

			var props = dgvProperties.SelectedRows.OfType<DataGridViewRow>()
				.OrderBy(row => row.Index)
				.Select(row => (row.DataBoundItem as DataRowView).Row as dsAssembly.PropertyRow).ToArray();			

			tbOutput.Text = style.Render(props);
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(tbOutput.Text);
		}
	}
}