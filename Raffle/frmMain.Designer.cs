namespace Raffle
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cbTemplate = new System.Windows.Forms.Label();
			this.dgvTypes = new System.Windows.Forms.DataGridView();
			this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbTypeFilter = new System.Windows.Forms.TextBox();
			this.tbAssembly = new Raffle.Controls.BuilderTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvProperties = new System.Windows.Forms.DataGridView();
			this.colPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPropertyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHtmlTemplate = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbTemplate);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.tbAssembly);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(639, 85);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Assembly:";
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 275);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(639, 54);
			this.panel2.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 85);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgvTypes);
			this.splitContainer1.Panel1.Controls.Add(this.tbTypeFilter);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvProperties);
			this.splitContainer1.Panel2.Controls.Add(this.panel3);
			this.splitContainer1.Size = new System.Drawing.Size(639, 190);
			this.splitContainer1.SplitterDistance = 292;
			this.splitContainer1.TabIndex = 2;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(108, 47);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(238, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// cbTemplate
			// 
			this.cbTemplate.AutoSize = true;
			this.cbTemplate.Location = new System.Drawing.Point(38, 50);
			this.cbTemplate.Name = "cbTemplate";
			this.cbTemplate.Size = new System.Drawing.Size(64, 13);
			this.cbTemplate.TabIndex = 4;
			this.cbTemplate.Text = "Template:";
			// 
			// dgvTypes
			// 
			this.dgvTypes.AllowUserToAddRows = false;
			this.dgvTypes.AllowUserToDeleteRows = false;
			this.dgvTypes.AllowUserToResizeRows = false;
			this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTypeName});
			this.dgvTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTypes.Location = new System.Drawing.Point(0, 21);
			this.dgvTypes.MultiSelect = false;
			this.dgvTypes.Name = "dgvTypes";
			this.dgvTypes.ReadOnly = true;
			this.dgvTypes.RowHeadersVisible = false;
			this.dgvTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTypes.Size = new System.Drawing.Size(292, 169);
			this.dgvTypes.TabIndex = 0;
			// 
			// colTypeName
			// 
			this.colTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colTypeName.DataPropertyName = "FullName";
			this.colTypeName.HeaderText = "Type Name";
			this.colTypeName.Name = "colTypeName";
			this.colTypeName.ReadOnly = true;
			// 
			// tbTypeFilter
			// 
			this.tbTypeFilter.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbTypeFilter.Location = new System.Drawing.Point(0, 0);
			this.tbTypeFilter.Name = "tbTypeFilter";
			this.tbTypeFilter.Size = new System.Drawing.Size(292, 21);
			this.tbTypeFilter.TabIndex = 1;
			this.tbTypeFilter.TextChanged += new System.EventHandler(this.tbTypeFilter_TextChanged);
			// 
			// tbAssembly
			// 
			this.tbAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAssembly.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAssembly.Location = new System.Drawing.Point(108, 15);
			this.tbAssembly.Name = "tbAssembly";
			this.tbAssembly.Size = new System.Drawing.Size(519, 26);
			this.tbAssembly.Suggestions = null;
			this.tbAssembly.TabIndex = 2;
			this.tbAssembly.BuilderClicked += new Raffle.Controls.BuilderEventHandler(this.tbAssembly_BuilderClicked);
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(343, 21);
			this.panel3.TabIndex = 0;
			// 
			// dgvProperties
			// 
			this.dgvProperties.AllowUserToAddRows = false;
			this.dgvProperties.AllowUserToDeleteRows = false;
			this.dgvProperties.AllowUserToResizeRows = false;
			this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPropertyName,
            this.colPropertyType,
            this.colHtmlTemplate});
			this.dgvProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProperties.Location = new System.Drawing.Point(0, 21);
			this.dgvProperties.Name = "dgvProperties";
			this.dgvProperties.RowHeadersVisible = false;
			this.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProperties.Size = new System.Drawing.Size(343, 169);
			this.dgvProperties.TabIndex = 1;
			// 
			// colPropertyName
			// 
			this.colPropertyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPropertyName.DataPropertyName = "PropertyName";
			this.colPropertyName.HeaderText = "Property";
			this.colPropertyName.Name = "colPropertyName";
			this.colPropertyName.ReadOnly = true;
			// 
			// colPropertyType
			// 
			this.colPropertyType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPropertyType.DataPropertyName = "TypeName";
			this.colPropertyType.HeaderText = "Type";
			this.colPropertyType.Name = "colPropertyType";
			this.colPropertyType.ReadOnly = true;
			// 
			// colHtmlTemplate
			// 
			this.colHtmlTemplate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colHtmlTemplate.HeaderText = "Template";
			this.colHtmlTemplate.Name = "colHtmlTemplate";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 329);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Raffle";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Controls.BuilderTextBox tbAssembly;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label cbTemplate;
		private System.Windows.Forms.DataGridView dgvTypes;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
		private System.Windows.Forms.TextBox tbTypeFilter;
		private System.Windows.Forms.DataGridView dgvProperties;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyType;
		private System.Windows.Forms.DataGridViewComboBoxColumn colHtmlTemplate;
	}
}

