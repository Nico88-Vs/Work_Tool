using Microsoft.EntityFrameworkCore;
using Work_Tool.PromptDialog;

namespace Work_Tool.Forms
{
    partial class IdeasWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Idea> ideas = new List<Idea>();
        private readonly DataContext _dataContext;

        public IdeasWindow(DataContext dataContext)
        {
            this._dataContext = dataContext;
            InitializeComponent();
        }

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
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.6F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45.4F) });
            this.tablePanel1.Controls.Add(this.textEdit2);
            this.tablePanel1.Controls.Add(this.textEdit1);
            this.tablePanel1.Controls.Add(this.dropDownButton1);
            this.tablePanel1.Controls.Add(button1);
            this.tablePanel1.Controls.Add(label3);
            this.tablePanel1.Controls.Add(label2);
            this.tablePanel1.Controls.Add(label1);
            this.tablePanel1.Dock = DockStyle.Fill;
            this.tablePanel1.Location = new Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 55F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 89F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            this.tablePanel1.Size = new Size(523, 290);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // textEdit1
            // 
            this.tablePanel1.SetColumn(this.textEdit1, 1);
            this.textEdit1.Location = new Point(135, 91);
            this.textEdit1.Name = "textEdit1";
            this.tablePanel1.SetRow(this.textEdit1, 1);
            this.textEdit1.Size = new Size(375, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // dropDownButton1
            // 
            this.tablePanel1.SetColumn(this.dropDownButton1, 1);
            this.dropDownButton1.Location = new Point(135, 237);
            this.dropDownButton1.Name = "dropDownButton1";
            this.tablePanel1.SetRow(this.dropDownButton1, 3);
            this.dropDownButton1.Size = new Size(375, 23);
            this.dropDownButton1.TabIndex = 4;
            this.dropDownButton1.Text = "label";
            // 
            // button1
            // 
            this.tablePanel1.SetColumn(button1, 0);
            button1.Location = new Point(13, 237);
            button1.Name = "button1";
            this.tablePanel1.SetRow(button1, 3);
            button1.Size = new Size(118, 23);
            button1.TabIndex = 3;
            button1.Text = "crea";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tablePanel1.SetColumn(label3, 0);
            label3.Location = new Point(14, 167);
            label3.Name = "label3";
            this.tablePanel1.SetRow(label3, 2);
            label3.Size = new Size(60, 13);
            label3.TabIndex = 2;
            label3.Text = "descrizione";
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tablePanel1.SetColumn(label2, 0);
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            this.tablePanel1.SetRow(label2, 1);
            label2.Size = new Size(34, 13);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            this.tablePanel1.SetColumn(label1, 1);
            label1.Location = new Point(136, 35);
            label1.Name = "label1";
            this.tablePanel1.SetRow(label1, 0);
            label1.Size = new Size(34, 13);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += this.label1_Click;
            // 
            // textEdit2
            // 
            this.tablePanel1.SetColumn(this.textEdit2, 1);
            this.textEdit2.Location = new Point(135, 163);
            this.textEdit2.Name = "textEdit2";
            this.tablePanel1.SetRow(this.textEdit2, 2);
            this.textEdit2.Size = new Size(375, 20);
            this.textEdit2.TabIndex = 6;
            // 
            // IdeasWindow
            // 
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ClientSize = new Size(523, 290);
            this.Controls.Add(this.tablePanel1);
            this.Name = "IdeasWindow";
            this.Text = "Gestione Idee";
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ideaDescription = PromptDialog.PromptDialog.ShowDialog("Inserisci l'idea:", "Nuova Idea");
            if (!string.IsNullOrEmpty(ideaDescription))
            {
                var idea = new Idea(ideaDescription);
                _dataContext.Ideas.Add(idea);
                _dataContext.SaveChanges();
            }
        }


        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}