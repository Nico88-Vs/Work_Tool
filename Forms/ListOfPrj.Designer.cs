namespace Work_Tool.Forms
{
    partial class ListOfPrj
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
            listOfPrjListView = new ListView();
            this.SuspendLayout();
            // 
            // listOfPrjListView
            // 
            listOfPrjListView.Alignment = ListViewAlignment.SnapToGrid;
            listOfPrjListView.Dock = DockStyle.Fill;
            listOfPrjListView.FullRowSelect = true;
            listOfPrjListView.GridLines = true;
            listOfPrjListView.Location = new Point(0, 0);
            listOfPrjListView.Name = "listOfPrjListView";
            listOfPrjListView.Size = new Size(800, 450);
            listOfPrjListView.TabIndex = 0;
            listOfPrjListView.UseCompatibleStateImageBehavior = false;
            listOfPrjListView.View = View.List;
            // 
            // ListOfPrj
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(listOfPrjListView);
            this.Name = "ListOfPrj";
            this.Text = "ListOfPrj";
            this.ResumeLayout(false);
        }

        #endregion

        private ListView listOfPrjListView;
    }
}