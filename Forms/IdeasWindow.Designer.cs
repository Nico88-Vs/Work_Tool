namespace Work_Tool.Forms
{
    partial class IdeasWindow
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
            label_DD_list = new ComboBox();
            label4 = new Label();
            this.simpleButton_puschIdea = new DevExpress.XtraEditors.SimpleButton();
            textBox_Descrizione = new TextBox();
            textBox_Nome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.28F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.72F) });
            this.tablePanel1.Controls.Add(label_DD_list);
            this.tablePanel1.Controls.Add(label4);
            this.tablePanel1.Controls.Add(this.simpleButton_puschIdea);
            this.tablePanel1.Controls.Add(textBox_Descrizione);
            this.tablePanel1.Controls.Add(textBox_Nome);
            this.tablePanel1.Controls.Add(label3);
            this.tablePanel1.Controls.Add(label2);
            this.tablePanel1.Controls.Add(label1);
            this.tablePanel1.Dock = DockStyle.Fill;
            this.tablePanel1.Location = new Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 103F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 79F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 89F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 83F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            this.tablePanel1.Size = new Size(800, 450);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.UseSkinIndents = true;
            // 
            // label_DD_list
            // 
            this.tablePanel1.SetColumn(label_DD_list, 1);
            label_DD_list.FormattingEnabled = true;
            label_DD_list.Location = new Point(180, 311);
            label_DD_list.Margin = new Padding(10);
            label_DD_list.Name = "label_DD_list";
            this.tablePanel1.SetRow(label_DD_list, 3);
            label_DD_list.Size = new Size(599, 21);
            label_DD_list.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            this.tablePanel1.SetColumn(label4, 1);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Tahoma", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(173, 10);
            label4.Name = "label4";
            this.tablePanel1.SetRow(label4, 0);
            label4.Size = new Size(613, 103);
            label4.TabIndex = 7;
            label4.Text = "Create Ideas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // simpleButton_puschIdea
            // 
            this.tablePanel1.SetColumn(this.simpleButton_puschIdea, 1);
            this.simpleButton_puschIdea.Location = new Point(180, 390);
            this.simpleButton_puschIdea.Margin = new Padding(10);
            this.simpleButton_puschIdea.Name = "simpleButton_puschIdea";
            this.tablePanel1.SetRow(this.simpleButton_puschIdea, 4);
            this.simpleButton_puschIdea.Size = new Size(599, 23);
            this.simpleButton_puschIdea.TabIndex = 6;
            this.simpleButton_puschIdea.Text = "Pusch Idea";
            this.simpleButton_puschIdea.Click += this.simpleButton_puschIdea_Click;
            // 
            // textBox_Descrizione
            // 
            this.tablePanel1.SetColumn(textBox_Descrizione, 1);
            textBox_Descrizione.Location = new Point(180, 225);
            textBox_Descrizione.Margin = new Padding(10);
            textBox_Descrizione.Multiline = true;
            textBox_Descrizione.Name = "textBox_Descrizione";
            this.tablePanel1.SetRow(textBox_Descrizione, 2);
            textBox_Descrizione.Size = new Size(599, 23);
            textBox_Descrizione.TabIndex = 5;
            // 
            // textBox_Nome
            // 
            this.tablePanel1.SetColumn(textBox_Nome, 1);
            textBox_Nome.Location = new Point(180, 142);
            textBox_Nome.Margin = new Padding(10);
            textBox_Nome.Name = "textBox_Nome";
            this.tablePanel1.SetRow(textBox_Nome, 1);
            textBox_Nome.Size = new Size(599, 21);
            textBox_Nome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            this.tablePanel1.SetColumn(label3, 0);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 281);
            label3.Name = "label3";
            this.tablePanel1.SetRow(label3, 3);
            label3.Size = new Size(153, 83);
            label3.TabIndex = 2;
            label3.Text = "Label";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += this.label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            this.tablePanel1.SetColumn(label2, 0);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 192);
            label2.Name = "label2";
            this.tablePanel1.SetRow(label2, 2);
            label2.Size = new Size(153, 89);
            label2.TabIndex = 1;
            label2.Text = "Descrizione";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += this.label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            this.tablePanel1.SetColumn(label1, 0);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 113);
            label1.Name = "label1";
            this.tablePanel1.SetRow(label1, 1);
            label1.Size = new Size(153, 79);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IdeasWindow
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tablePanel1);
            this.Name = "IdeasWindow";
            this.Text = "IdeasWindow";
            ((System.ComponentModel.ISupportInitialize)this.tablePanel1).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton_puschIdea;
        private TextBox textBox_Descrizione;
        private TextBox textBox_Nome;
        private ComboBox label_DD_list;
    }
}