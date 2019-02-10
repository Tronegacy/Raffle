using JsonSettings;
using Raffle.Classes;
using Raffle.Extensions;
using Raffle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
			cbOrientation.FillFromEnum<Orientation>();

			LoadFields();
			InitDataBinding();

			if (File.Exists(tbAssembly.Text))
			{
				_assembly = dsAssembly.FromAssembly(tbAssembly.Text);
				InitDataGrids();
			}
		}

		private Style[] LoadStyles()
		{
			List<Style> results = new List<Style>();

			results.AddRange(Style.FromResourcePath("Raffle.Styles"));

			results.AddRange(Style.FromFilePath(_settings.StylePath));

			return results.ToArray();
		}

		private void LoadFields()
		{
			tbAssembly.Text = _settings.AssemblyFile;
			tbStylePath.Text = _settings.StylePath;
			cbStyle.SelectedIndex = cbStyle.FindString(_settings.Style);
			cbOrientation.SelectedIndex = cbOrientation.FindString(_settings.SplitterOrientation.ToString());
			splitContainer1.Orientation = _settings.SplitterOrientation;
		}

		private void InitDataBinding()
		{
			tbAssembly.TextChanged += delegate (object sender, EventArgs e) { _settings.AssemblyFile = tbAssembly.Text; };

			tbStylePath.TextChanged += delegate (object sender, EventArgs e) { _settings.StylePath = tbStylePath.Text; };

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
			var props = dgvProperties.SelectedRows.OfType<DataGridViewRow>()
				.OrderBy(row => row.Index)
				.Select(row => (row.DataBoundItem as DataRowView).Row as dsAssembly.PropertyRow).ToArray();

			RenderHtmlOutput(props);
			RenderModelClass(props);
		}

		private void RenderModelClass(dsAssembly.PropertyRow[] props)
		{
			StringBuilder output = new StringBuilder();

			dsAssembly.TypeRow currentType = SelectedType();
			output.AppendLine($"public class {currentType.ShortName}Edit\r\n{{");

			foreach (var prop in props) output.AppendLine("\t" + prop.CSharpSyntax);

			output.AppendLine("}");

			tbCSharpOutput.Text = output.ToString();
		}

		private dsAssembly.TypeRow SelectedType()
		{
			return dgvTypes.SelectedRows.OfType<DataGridViewRow>()
				.Select(row => (row.DataBoundItem as DataRowView).Row as dsAssembly.TypeRow)
				.First();
		}

		private void RenderHtmlOutput(dsAssembly.PropertyRow[] props)
		{
			var style = cbStyle.SelectedItem as Style;
			if (style == null)
			{
				MessageBox.Show("No style selected.");
				return;
			}

			tbHtmlOutput.Text = style.Render(props);
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedIndex)
			{
				case 0: // html
					Clipboard.SetText(tbHtmlOutput.Text);
					break;

				case 1: // c#
					Clipboard.SetText(tbCSharpOutput.Text);
					break;
			}
		}

		private void tbStylePath_BuilderClicked(object sender, Controls.BuilderEventArgs e)
		{
			if (tbStylePath.SelectFolder(e))
			{
				_styles = LoadStyles();
				cbStyle.Items.Clear();
				cbStyle.Items.AddRange(_styles);
			}
		}
	}
}