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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgvTypes = new System.Windows.Forms.DataGridView();
			this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbTypeFilter = new System.Windows.Forms.TextBox();
			this.tbAssembly = new Raffle.Controls.BuilderTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvProperties = new System.Windows.Forms.DataGridView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tbOutput = new FastColoredTextBoxNS.FastColoredTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnCopy = new System.Windows.Forms.ToolStripButton();
			this.colPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPropertyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIsNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cbStyle = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbOutput)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbStyle);
			this.panel1.Controls.Add(this.tbAssembly);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(747, 83);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Assembly:";
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 325);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(747, 54);
			this.panel2.TabIndex = 0;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
			this.splitContainer1.Size = new System.Drawing.Size(346, 242);
			this.splitContainer1.SplitterDistance = 175;
			this.splitContainer1.TabIndex = 2;
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
			this.dgvTypes.Size = new System.Drawing.Size(175, 221);
			this.dgvTypes.TabIndex = 1;
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
			this.tbTypeFilter.Size = new System.Drawing.Size(175, 21);
			this.tbTypeFilter.TabIndex = 0;
			this.tbTypeFilter.TextChanged += new System.EventHandler(this.tbTypeFilter_TextChanged);
			// 
			// tbAssembly
			// 
			this.tbAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAssembly.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAssembly.Location = new System.Drawing.Point(108, 15);
			this.tbAssembly.Name = "tbAssembly";
			this.tbAssembly.Size = new System.Drawing.Size(627, 26);
			this.tbAssembly.Suggestions = null;
			this.tbAssembly.TabIndex = 1;
			this.tbAssembly.BuilderClicked += new Raffle.Controls.BuilderEventHandler(this.tbAssembly_BuilderClicked);
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(167, 21);
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
            this.colIsNullable});
			this.dgvProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProperties.Location = new System.Drawing.Point(0, 21);
			this.dgvProperties.Name = "dgvProperties";
			this.dgvProperties.RowHeadersVisible = false;
			this.dgvProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProperties.Size = new System.Drawing.Size(167, 221);
			this.dgvProperties.TabIndex = 1;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 83);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tbOutput);
			this.splitContainer2.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer2.Size = new System.Drawing.Size(747, 242);
			this.splitContainer2.SplitterDistance = 346;
			this.splitContainer2.TabIndex = 3;
			// 
			// tbOutput
			// 
			this.tbOutput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
			this.tbOutput.AutoIndentCharsPatterns = "";
			this.tbOutput.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.tbOutput.BackBrush = null;
			this.tbOutput.CharHeight = 14;
			this.tbOutput.CharWidth = 8;
			this.tbOutput.CommentPrefix = null;
			this.tbOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbOutput.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.tbOutput.IsReplaceMode = false;
			this.tbOutput.Language = FastColoredTextBoxNS.Language.HTML;
			this.tbOutput.LeftBracket = '<';
			this.tbOutput.LeftBracket2 = '(';
			this.tbOutput.Location = new System.Drawing.Point(0, 25);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Paddings = new System.Windows.Forms.Padding(0);
			this.tbOutput.RightBracket = '>';
			this.tbOutput.RightBracket2 = ')';
			this.tbOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.tbOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbOutput.ServiceColors")));
			this.tbOutput.Size = new System.Drawing.Size(397, 217);
			this.tbOutput.TabIndex = 1;
			this.tbOutput.Zoom = 100;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnCopy});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(397, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(50, 22);
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
			this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(39, 22);
			this.btnCopy.Text = "Copy";
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
			// colIsNullable
			// 
			this.colIsNullable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colIsNullable.DataPropertyName = "IsNullable";
			this.colIsNullable.HeaderText = "N";
			this.colIsNullable.Name = "colIsNullable";
			this.colIsNullable.ToolTipText = "Nullable";
			this.colIsNullable.Width = 21;
			// 
			// cbStyle
			// 
			this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStyle.FormattingEnabled = true;
			this.cbStyle.Location = new System.Drawing.Point(108, 47);
			this.cbStyle.Name = "cbStyle";
			this.cbStyle.Size = new System.Drawing.Size(192, 21);
			this.cbStyle.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Style:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 379);
			this.Controls.Add(this.splitContainer2);
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
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbOutput)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Controls.BuilderTextBox tbAssembly;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvTypes;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
		private System.Windows.Forms.TextBox tbTypeFilter;
		private System.Windows.Forms.DataGridView dgvProperties;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private FastColoredTextBoxNS.FastColoredTextBox tbOutput;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripButton btnCopy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyType;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colIsNullable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbStyle;
	}
}

