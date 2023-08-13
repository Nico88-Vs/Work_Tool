using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tool.Forms
{
    public partial class CustomDialogForm : Form
    {
        public TextBox textBox_name { get; set; } = new TextBox() { Left = 10, Top = 50, Width = 250, MaxLength = 12 };
        public TextBox textBox_template { get; set; } = new TextBox() { Left = 10, Top = 110, Width = 250, Multiline = true };
        public TextBox textBox_desc { get; set; } = new TextBox() { Left = 10, Top = 170, Width = 250, MaxLength = 35 };


        public CustomDialogForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Dimensioni e titolo della form
            this.Text = "Dialogo personalizzato";
            this.Width = 300;
            this.Height = 300;

            // Primo label e textbox
            Label label1 = new Label() { Text = "Nome:", Left = 10, Top = 20, Width = 250 };

            // Secondo label e textbox
            Label label2 = new Label() { Text = "Template:", Left = 10, Top = 80, Width = 250 };

            // Secondo label e textbox
            Label label3 = new Label() { Text = "Descrizione:", Left = 10, Top = 140, Width = 250 };

            // Pulsanti OK e Cancel
            Button okButton = new Button() { Text = "OK", Left = 30, Width = 100, Top = 200, DialogResult = DialogResult.OK };
            Button cancelButton = new Button() { Text = "Annulla", Left = 150, Width = 100, Top = 200, DialogResult = DialogResult.Cancel };

            this.Controls.Add(label1);
            this.Controls.Add(textBox_name);
            this.Controls.Add(label2);
            this.Controls.Add(textBox_template);
            this.Controls.Add(label3);
            this.Controls.Add(textBox_desc);
            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }

}
