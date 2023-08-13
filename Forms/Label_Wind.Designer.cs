namespace Work_Tool.Forms
{
    partial class Label_Wind
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
            this.colorEdit_DropDown = new DevExpress.XtraEditors.ColorEdit();
            this.textEdit_Nome = new DevExpress.XtraEditors.TextEdit();
            button_Crea = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.colorEdit_DropDown.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.textEdit_Nome.Properties).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.6F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.4F) });
            this.tablePanel1.Controls.Add(this.colorEdit_DropDown);
            this.tablePanel1.Controls.Add(this.textEdit_Nome);
            this.tablePanel1.Controls.Add(button_Crea);
            this.tablePanel1.Controls.Add(label3);
            this.tablePanel1.Controls.Add(label2);
            this.tablePanel1.Controls.Add(label1);
            this.tablePanel1.Dock = DockStyle.Fill;
            this.tablePanel1.Location = new Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 99F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 115F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            this.tablePanel1.Size = new Size(800, 450);
            this.tablePanel1.TabIndex = 1;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // colorEdit_DropDown
            // 
            this.tablePanel1.SetColumn(this.colorEdit_DropDown, 1);
            this.colorEdit_DropDown.EditValue = Color.Empty;
            this.colorEdit_DropDown.Location = new Point(202, 220);
            this.colorEdit_DropDown.Name = "colorEdit_DropDown";
            this.colorEdit_DropDown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.colorEdit_DropDown.Properties.NullColor = Color.Empty;
            this.tablePanel1.SetRow(this.colorEdit_DropDown, 2);
            this.colorEdit_DropDown.Size = new Size(585, 20);
            this.colorEdit_DropDown.TabIndex = 6;
            // 
            // textEdit_Nome
            // 
            this.tablePanel1.SetColumn(this.textEdit_Nome, 1);
            this.textEdit_Nome.Location = new Point(202, 113);
            this.textEdit_Nome.Name = "textEdit_Nome";
            this.tablePanel1.SetRow(this.textEdit_Nome, 1);
            this.textEdit_Nome.Size = new Size(585, 20);
            this.textEdit_Nome.TabIndex = 5;
            // 
            // button_Crea
            // 
            this.tablePanel1.SetColumn(button_Crea, 1);
            button_Crea.Location = new Point(202, 352);
            button_Crea.Name = "button_Crea";
            this.tablePanel1.SetRow(button_Crea, 3);
            button_Crea.Size = new Size(585, 23);
            button_Crea.TabIndex = 3;
            button_Crea.Text = "crea";
            button_Crea.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tablePanel1.SetColumn(label3, 0);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 173);
            label3.Name = "label3";
            this.tablePanel1.SetRow(label3, 2);
            label3.Size = new Size(183, 115);
            label3.TabIndex = 2;
            label3.Text = "Colore";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tablePanel1.SetColumn(label2, 0);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            this.tablePanel1.SetRow(label2, 1);
            label2.Size = new Size(183, 99);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            this.tablePanel1.SetColumn(label1, 1);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 10);
            label1.Name = "label1";
            this.tablePanel1.SetRow(label1, 0);
            label1.Size = new Size(583, 64);
            label1.TabIndex = 0;
            label1.Text = "Create your Labels";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Wind
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Label_Wind";
            this.Text = "Gestione Label";
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.colorEdit_DropDown.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.textEdit_Nome.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.ColorEdit colorEdit_DropDown;
        private DevExpress.XtraEditors.TextEdit textEdit_Nome;
        private Button button_Crea;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}