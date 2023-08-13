namespace Work_Tool.Custom_Controls
{
    partial class Carusel_Prj_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carusel_Prj_));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            this.progect_Details1 = new Progect_Details();
            this.progect_Details2 = new Progect_Details();
            this.progect_Details3 = new Progect_Details();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(917, 150);
            splitContainer1.SplitterDistance = 852;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(this.simpleButton1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(this.simpleButton2);
            splitContainer2.Size = new Size(61, 150);
            splitContainer2.SplitterDistance = 69;
            splitContainer2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.Dock = DockStyle.Fill;
            this.simpleButton1.ImageOptions.Image = (Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new Size(61, 69);
            this.simpleButton1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = DockStyle.Fill;
            this.simpleButton2.ImageOptions.Image = (Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new Size(61, 77);
            this.simpleButton2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(this.progect_Details1);
            flowLayoutPanel1.Controls.Add(this.progect_Details2);
            flowLayoutPanel1.Controls.Add(this.progect_Details3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(852, 150);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // progect_Details1
            // 
            this.progect_Details1.AutoSize = true;
            this.progect_Details1.Location = new Point(0, 0);
            this.progect_Details1.Margin = new Padding(0);
            this.progect_Details1.Name = "progect_Details1";
            this.progect_Details1.Size = new Size(325, 177);
            this.progect_Details1.TabIndex = 0;
            // 
            // progect_Details2
            // 
            this.progect_Details2.AutoSize = true;
            this.progect_Details2.Location = new Point(325, 0);
            this.progect_Details2.Margin = new Padding(0);
            this.progect_Details2.Name = "progect_Details2";
            this.progect_Details2.Size = new Size(325, 177);
            this.progect_Details2.TabIndex = 1;
            // 
            // progect_Details3
            // 
            this.progect_Details3.AutoSize = true;
            this.progect_Details3.Location = new Point(650, 0);
            this.progect_Details3.Margin = new Padding(0);
            this.progect_Details3.Name = "progect_Details3";
            this.progect_Details3.Size = new Size(325, 177);
            this.progect_Details3.TabIndex = 2;
            // 
            // Carusel_Prj_
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(splitContainer1);
            this.Margin = new Padding(0);
            this.Name = "Carusel_Prj_";
            this.Size = new Size(917, 150);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Progect_Details progect_Details1;
        private Progect_Details progect_Details2;
        private Progect_Details progect_Details3;
    }
}
