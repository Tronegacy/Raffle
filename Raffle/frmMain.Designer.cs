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
			this.cbOrientation = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbStyle = new System.Windows.Forms.ComboBox();
			this.tbAssembly = new Raffle.Controls.BuilderTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dgvProperties = new System.Windows.Forms.DataGridView();
			this.colPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPropertyType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIsNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tbHtmlOutput = new FastColoredTextBoxNS.FastColoredTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tbCSharpOutput = new FastColoredTextBoxNS.FastColoredTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnCopy = new System.Windows.Forms.ToolStripButton();
			this.dgvTypes = new System.Windows.Forms.DataGridView();
			this.colTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbTypeFilter = new System.Windows.Forms.TextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tbStylePath = new Raffle.Controls.BuilderTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbHtmlOutput)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbCSharpOutput)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbStylePath);
			this.panel1.Controls.Add(this.cbOrientation);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbStyle);
			this.panel1.Controls.Add(this.tbAssembly);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(851, 110);
			this.panel1.TabIndex = 0;
			// 
			// cbOrientation
			// 
			this.cbOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOrientation.FormattingEnabled = true;
			this.cbOrientation.Location = new System.Drawing.Point(718, 77);
			this.cbOrientation.Name = "cbOrientation";
			this.cbOrientation.Size = new System.Drawing.Size(121, 21);
			this.cbOrientation.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Style:";
			// 
			// cbStyle
			// 
			this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStyle.FormattingEnabled = true;
			this.cbStyle.Location = new System.Drawing.Point(108, 77);
			this.cbStyle.Name = "cbStyle";
			this.cbStyle.Size = new System.Drawing.Size(192, 21);
			this.cbStyle.TabIndex = 3;
			// 
			// tbAssembly
			// 
			this.tbAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAssembly.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAssembly.Location = new System.Drawing.Point(108, 15);
			this.tbAssembly.Name = "tbAssembly";
			this.tbAssembly.Size = new System.Drawing.Size(731, 26);
			this.tbAssembly.Suggestions = null;
			this.tbAssembly.TabIndex = 1;
			this.tbAssembly.BuilderClicked += new Raffle.Controls.BuilderEventHandler(this.tbAssembly_BuilderClicked);
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
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgvProperties);
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(581, 370);
			this.splitContainer1.SplitterDistance = 173;
			this.splitContainer1.TabIndex = 2;
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
			this.dgvProperties.Size = new System.Drawing.Size(581, 152);
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
			// colIsNullable
			// 
			this.colIsNullable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colIsNullable.DataPropertyName = "IsNullable";
			this.colIsNullable.HeaderText = "N";
			this.colIsNullable.Name = "colIsNullable";
			this.colIsNullable.ToolTipText = "Nullable";
			this.colIsNullable.Width = 21;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(581, 21);
			this.panel3.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(581, 168);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tbHtmlOutput);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(573, 142);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Html";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tbHtmlOutput
			// 
			this.tbHtmlOutput.AutoCompleteBracketsList = new char[] {
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
			this.tbHtmlOutput.AutoIndentCharsPatterns = "";
			this.tbHtmlOutput.AutoScrollMinSize = new System.Drawing.Size(27, 14);
			this.tbHtmlOutput.BackBrush = null;
			this.tbHtmlOutput.CharHeight = 14;
			this.tbHtmlOutput.CharWidth = 8;
			this.tbHtmlOutput.CommentPrefix = null;
			this.tbHtmlOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbHtmlOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.tbHtmlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbHtmlOutput.IsReplaceMode = false;
			this.tbHtmlOutput.Language = FastColoredTextBoxNS.Language.HTML;
			this.tbHtmlOutput.LeftBracket = '<';
			this.tbHtmlOutput.LeftBracket2 = '(';
			this.tbHtmlOutput.Location = new System.Drawing.Point(3, 3);
			this.tbHtmlOutput.Name = "tbHtmlOutput";
			this.tbHtmlOutput.Paddings = new System.Windows.Forms.Padding(0);
			this.tbHtmlOutput.RightBracket = '>';
			this.tbHtmlOutput.RightBracket2 = ')';
			this.tbHtmlOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.tbHtmlOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbHtmlOutput.ServiceColors")));
			this.tbHtmlOutput.Size = new System.Drawing.Size(567, 136);
			this.tbHtmlOutput.TabIndex = 1;
			this.tbHtmlOutput.Zoom = 100;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tbCSharpOutput);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(573, 156);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Model Class";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tbCSharpOutput
			// 
			this.tbCSharpOutput.AutoCompleteBracketsList = new char[] {
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
			this.tbCSharpOutput.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.tbCSharpOutput.AutoScrollMinSize = new System.Drawing.Size(2, 14);
			this.tbCSharpOutput.BackBrush = null;
			this.tbCSharpOutput.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.tbCSharpOutput.CharHeight = 14;
			this.tbCSharpOutput.CharWidth = 8;
			this.tbCSharpOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbCSharpOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.tbCSharpOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbCSharpOutput.IsReplaceMode = false;
			this.tbCSharpOutput.Language = FastColoredTextBoxNS.Language.CSharp;
			this.tbCSharpOutput.LeftBracket = '(';
			this.tbCSharpOutput.LeftBracket2 = '{';
			this.tbCSharpOutput.Location = new System.Drawing.Point(3, 3);
			this.tbCSharpOutput.Name = "tbCSharpOutput";
			this.tbCSharpOutput.Paddings = new System.Windows.Forms.Padding(0);
			this.tbCSharpOutput.RightBracket = ')';
			this.tbCSharpOutput.RightBracket2 = '}';
			this.tbCSharpOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.tbCSharpOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbCSharpOutput.ServiceColors")));
			this.tbCSharpOutput.Size = new System.Drawing.Size(567, 150);
			this.tbCSharpOutput.TabIndex = 0;
			this.tbCSharpOutput.Zoom = 100;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnCopy});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(581, 25);
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
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
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
			this.dgvTypes.Size = new System.Drawing.Size(266, 349);
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
			this.tbTypeFilter.Size = new System.Drawing.Size(266, 21);
			this.tbTypeFilter.TabIndex = 0;
			this.tbTypeFilter.TextChanged += new System.EventHandler(this.tbTypeFilter_TextChanged);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 110);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dgvTypes);
			this.splitContainer2.Panel1.Controls.Add(this.tbTypeFilter);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer2.Size = new System.Drawing.Size(851, 370);
			this.splitContainer2.SplitterDistance = 266;
			this.splitContainer2.TabIndex = 3;
			// 
			// tbStylePath
			// 
			this.tbStylePath.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbStylePath.Location = new System.Drawing.Point(108, 44);
			this.tbStylePath.Name = "tbStylePath";
			this.tbStylePath.Size = new System.Drawing.Size(731, 26);
			this.tbStylePath.Suggestions = null;
			this.tbStylePath.TabIndex = 5;
			this.tbStylePath.BuilderClicked += new Raffle.Controls.BuilderEventHandler(this.tbStylePath_BuilderClicked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Style Path:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 480);
			this.Controls.Add(this.splitContainer2);
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
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbHtmlOutput)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tbCSharpOutput)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private Controls.BuilderTextBox tbAssembly;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dgvTypes;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTypeName;
		private System.Windows.Forms.TextBox tbTypeFilter;
		private System.Windows.Forms.DataGridView dgvProperties;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private FastColoredTextBoxNS.FastColoredTextBox tbHtmlOutput;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripButton btnCopy;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPropertyType;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colIsNullable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbStyle;
		private System.Windows.Forms.ComboBox cbOrientation;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private FastColoredTextBoxNS.FastColoredTextBox tbCSharpOutput;
		private System.Windows.Forms.Label label3;
		private Controls.BuilderTextBox tbStylePath;
	}
}

