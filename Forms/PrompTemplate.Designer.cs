namespace Work_Tool.Forms
{
    partial class PrompTemplate
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
            TemplateListView = new ListView();
            splitContainer1 = new SplitContainer();
            AddControll = new Button();
            Get_Prompt = new Button();
            MainTableLayout = new TableLayoutPanel();
            Template_Modifier = new TextBox();
            Export = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TemplateListView
            // 
            TemplateListView.Dock = DockStyle.Fill;
            TemplateListView.FullRowSelect = true;
            TemplateListView.GridLines = true;
            TemplateListView.Location = new Point(3, 3);
            TemplateListView.MultiSelect = false;
            TemplateListView.Name = "TemplateListView";
            TemplateListView.Size = new Size(716, 824);
            TemplateListView.TabIndex = 1;
            TemplateListView.UseCompatibleStateImageBehavior = false;
            TemplateListView.View = View.List;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 833);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(AddControll);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(Get_Prompt);
            splitContainer1.Size = new Size(716, 38);
            splitContainer1.SplitterDistance = 376;
            splitContainer1.TabIndex = 0;
            // 
            // AddControll
            // 
            AddControll.AutoSize = true;
            AddControll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddControll.Dock = DockStyle.Fill;
            AddControll.Location = new Point(0, 0);
            AddControll.Margin = new Padding(100);
            AddControll.Name = "AddControll";
            AddControll.Padding = new Padding(10);
            AddControll.Size = new Size(376, 38);
            AddControll.TabIndex = 0;
            AddControll.Text = "Add_Prompt";
            AddControll.UseVisualStyleBackColor = true;
            // 
            // Get_Prompt
            // 
            Get_Prompt.Dock = DockStyle.Fill;
            Get_Prompt.Location = new Point(0, 0);
            Get_Prompt.Name = "Get_Prompt";
            Get_Prompt.Size = new Size(336, 38);
            Get_Prompt.TabIndex = 0;
            Get_Prompt.Text = "Get_Prompt";
            Get_Prompt.UseVisualStyleBackColor = true;
            // 
            // MainTableLayout
            // 
            MainTableLayout.AutoSize = true;
            MainTableLayout.ColumnCount = 2;
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 812F));
            MainTableLayout.Controls.Add(splitContainer1, 0, 1);
            MainTableLayout.Controls.Add(TemplateListView, 0, 0);
            MainTableLayout.Controls.Add(Template_Modifier, 1, 0);
            MainTableLayout.Controls.Add(Export, 1, 1);
            MainTableLayout.Dock = DockStyle.Fill;
            MainTableLayout.Location = new Point(0, 0);
            MainTableLayout.Name = "MainTableLayout";
            MainTableLayout.RowCount = 2;
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            MainTableLayout.Size = new Size(1534, 874);
            MainTableLayout.TabIndex = 0;
            // 
            // Template_Modifier
            // 
            Template_Modifier.AcceptsReturn = true;
            Template_Modifier.AcceptsTab = true;
            Template_Modifier.AutoCompleteMode = AutoCompleteMode.Suggest;
            Template_Modifier.AutoCompleteSource = AutoCompleteSource.FileSystem;
            Template_Modifier.BackColor = SystemColors.WindowFrame;
            Template_Modifier.Dock = DockStyle.Fill;
            Template_Modifier.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Template_Modifier.ForeColor = Color.LawnGreen;
            Template_Modifier.Location = new Point(725, 3);
            Template_Modifier.Multiline = true;
            Template_Modifier.Name = "Template_Modifier";
            Template_Modifier.Size = new Size(806, 824);
            Template_Modifier.TabIndex = 2;
            // 
            // Export
            // 
            Export.Dock = DockStyle.Fill;
            Export.Location = new Point(725, 833);
            Export.Name = "Export";
            Export.Size = new Size(806, 38);
            Export.TabIndex = 3;
            Export.Text = "Export";
            Export.UseVisualStyleBackColor = true;
            // 
            // PrompTemplate
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1534, 874);
            this.Controls.Add(MainTableLayout);
            this.Name = "PrompTemplate";
            this.Text = "PrompTemplate";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            MainTableLayout.ResumeLayout(false);
            MainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private SplitContainer TopSplitContainer;
        private ListView TemplateListView;
        private SplitContainer splitContainer1;
        private Button AddControll;
        private Button Get_Prompt;
        private TableLayoutPanel MainTableLayout;
        private TextBox Template_Modifier;
        private Button Export;
    }
}