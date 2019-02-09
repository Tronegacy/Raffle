using JsonSettings;
using Raffle.Models;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Raffle
{
	public partial class frmMain : Form
	{
		private AppSettings _settings = null;
		private dsAssembly _assembly = null;

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

			LoadFields();
			InitDataBinding();

			if (File.Exists(tbAssembly.Text))
			{
				_assembly = dsAssembly.FromAssembly(tbAssembly.Text);
				InitDataGrids();
			}
		}

		private void LoadFields()
		{
			tbAssembly.Text = _settings.AssemblyFile;
		}

		private void InitDataBinding()
		{
			tbAssembly.TextChanged += delegate (object sender, EventArgs e) { _settings.AssemblyFile = tbAssembly.Text; };
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
	}
}