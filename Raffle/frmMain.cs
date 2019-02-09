using JsonSettings;
using Raffle.Models;
using System;
using System.Windows.Forms;

namespace Raffle
{
	public partial class frmMain : Form
	{
		private AppSettings _settings = null;

		public frmMain()
		{
			InitializeComponent();
		}

		private void tbAssembly_BuilderClicked(object sender, Controls.BuilderEventArgs e)
		{
			tbAssembly.SelectFile("Assemblies|*.dll;*.exe|All Files|*.*", e);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			_settings = JsonSettingsBase.Load<AppSettings>();

			LoadFields();
			InitDataBinding();
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
	}
}