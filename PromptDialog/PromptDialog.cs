using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Tool.PromptDialog
{
    public static class PromptDialog
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;
            Label label = new Label() { Left = 10, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 260, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 180, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(label);
            prompt.Controls.Add(textBox);
            prompt.AcceptButton = confirmation; // Pressing Enter will click the OK button

            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
