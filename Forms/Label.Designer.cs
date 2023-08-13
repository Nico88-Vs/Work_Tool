namespace Work_Tool.Forms
{
    partial class Label
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            button1 = new Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorEdit1 = new DevExpress.XtraEditors.ColorEdit();
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.colorEdit1.Properties).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.6F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.4F) });
            this.tablePanel1.Controls.Add(this.colorEdit1);
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(button1);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = DockStyle.Fill;
            this.tablePanel1.Location = new Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 55F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 89F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            this.tablePanel1.Size = new Size(800, 450);
            this.tablePanel1.TabIndex = 1;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 1);
            this.textEdit1.Location = new Point(202, 91);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel1.SetRow(this.textEdit1, 1);
            this.textEdit1.Size = new Size(585, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // button1
            // 
            this.tablePanel1.SetColumn(button1, 0);
            button1.Location = new Point(13, 317);
            button1.Name = "button1";
            this.tablePanel1.SetRow(button1, 3);
            button1.Size = new Size(185, 23);
            button1.TabIndex = 3;
            button1.Text = "crea";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Location = new Point(14, 167);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 2);
            this.label3.Size = new Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "colore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Location = new Point(14, 95);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 1);
            this.label1.Location = new Point(203, 35);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // colorEdit1
            // 
            this.tablePanel1.SetColumn(this.colorEdit1, 1);
            this.colorEdit1.EditValue = Color.Empty;
            this.colorEdit1.Location = new Point(202, 163);
            this.colorEdit1.Name = "colorEdit1";
            this.colorEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.colorEdit1.Properties.NullColor = Color.Empty;
            this.tablePanel1.SetRow(this.colorEdit1, 2);
            this.colorEdit1.Size = new Size(585, 20);
            this.colorEdit1.TabIndex = 6;
            // 
            // Label
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Label";
            this.Text = "Gestione Label";
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.colorEdit1.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.ColorEdit colorEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}