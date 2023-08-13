namespace Work_Tool.Custom_Controls
{
    partial class Progres_Bar_Main
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.stepProgressBar1 = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem4 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem5 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem6 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem7 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem8 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.stepProgressBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.7F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 87.45F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.85F) });
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(this.stepProgressBar1);
            this.tablePanel1.Controls.Add(this.dateEdit1);
            this.tablePanel1.Location = new Point(1, 2);
            this.tablePanel1.Margin = new Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 279F) });
            this.tablePanel1.Size = new Size(697, 300);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 2);
            this.textEdit1.Location = new Point(628, 139);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel1.SetRow(this.textEdit1, 0);
            this.textEdit1.Size = new Size(56, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // stepProgressBar1
            // 
            this.stepProgressBar1.AutoSize = true;
            this.tablePanel1.SetColumn(this.stepProgressBar1, 1);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem1);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem2);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem3);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem4);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem5);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem6);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem7);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem8);
            this.stepProgressBar1.Location = new Point(91, 112);
            this.stepProgressBar1.Name = "stepProgressBar1";
            this.tablePanel1.SetRow(this.stepProgressBar1, 0);
            this.stepProgressBar1.SelectedItemIndex = 0;
            this.stepProgressBar1.Size = new Size(532, 75);
            this.stepProgressBar1.TabIndex = 2;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.Appearance.ActiveIndicatorColor = SystemColors.ActiveCaption;
            this.stepProgressBarItem1.ContentBlock2.Caption = "Item1";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            this.stepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active;
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Caption = "Item2";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock2.Caption = "Item3";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // stepProgressBarItem4
            // 
            this.stepProgressBarItem4.ContentBlock2.Caption = "Item4";
            this.stepProgressBarItem4.Name = "stepProgressBarItem4";
            // 
            // stepProgressBarItem5
            // 
            this.stepProgressBarItem5.ContentBlock2.Caption = "Item5";
            this.stepProgressBarItem5.Name = "stepProgressBarItem5";
            // 
            // stepProgressBarItem6
            // 
            this.stepProgressBarItem6.ContentBlock2.Caption = "Item6";
            this.stepProgressBarItem6.Name = "stepProgressBarItem6";
            // 
            // stepProgressBarItem7
            // 
            this.stepProgressBarItem7.ContentBlock2.Caption = "Item7";
            this.stepProgressBarItem7.Name = "stepProgressBarItem7";
            // 
            // stepProgressBarItem8
            // 
            this.stepProgressBarItem8.ContentBlock2.Caption = "Item8";
            this.stepProgressBarItem8.Name = "stepProgressBarItem8";
            // 
            // dateEdit1
            // 
            this.tablePanel1.SetColumn(this.dateEdit1, 0);
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new Point(13, 139);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.tablePanel1.SetRow(this.dateEdit1, 0);
            this.dateEdit1.Size = new Size(74, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // Progres_Bar_Main
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tablePanel1);
            this.Name = "Progres_Bar_Main";
            this.Size = new Size(698, 302);
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.stepProgressBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dateEdit1.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBar1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem4;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem5;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem6;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem7;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem8;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
