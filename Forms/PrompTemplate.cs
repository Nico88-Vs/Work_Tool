using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tool.Forms
{
    public partial class PrompTemplate : Form
    {
        private readonly DataContext dataContext;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public PrompTemplate(DataContext dataContext)
        {
            timer.Interval = 2000;

            InitializeComponent();

            AddControll.Click += this.AddControll_Click;
            this.dataContext = dataContext;

            TemplateListView.ItemActivate += this.ListView1_ItemActivate;
            BindToListView(TemplateListView);

            Export.Click += this.Export_Click;
            timer.Tick += this.Timer_Tick;
        }

        private void Export_Click(object? sender, EventArgs e)
        {
            Clipboard.SetText(Template_Modifier.Text);
            timer.Start();
            Export.Text = "Copied";

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Export.Text = "Export";
            timer.Stop();
        }

        private async void ListView1_ItemActivate(object? sender, EventArgs e)
        {
            string outname = string.Empty;
            string outdesc = string.Empty;

            if (TemplateListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = TemplateListView.SelectedItems[0];
                string debug = selectedItem.Text;
                GetMetch(debug, out outname, out outdesc);

                string temp = await GeTemplate(outname, outdesc);

                Template_Modifier.Text = temp;
                //ShowCopyableMessage(temp);
            }
        }

        private async void AddControll_Click(object? sender, EventArgs e)
        {
            using (CustomDialogForm dialog = new CustomDialogForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string name = dialog.textBox_name.Text;
                    string template = dialog.textBox_template.Text;
                    string description = dialog.textBox_desc.Text;


                    Ptompt_Template template_obj = new Ptompt_Template();
                    template_obj.Name = name;
                    template_obj.Template = template;
                    template_obj.Description = description;

                    await dataContext.Template.AddAsync(template_obj);
                    await dataContext.SaveChangesAsync();

                    BindToListView(TemplateListView);
                }
            }
        }

        public void BindToListView(ListView listView)
        {
            var topics = dataContext.Template.ToList();

            listView.Items.Clear();
            foreach (var topic in topics)
            {
                string composition = $"Nome: {topic.Name},  Description: {topic.Description}";
                ListViewItem item = new ListViewItem(composition);

                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void ShowCopyableMessage(string message)
        {
            ToolStripDropDown dropDown = new ToolStripDropDown();
            dropDown.AutoSize = true;

            ToolStripTextBox textBox = new ToolStripTextBox
            {
                MaxLength = 150,
                Text = message,
                ReadOnly = true,
                Multiline = true,
                AutoSize = true,
            };

            ToolStripButton copyButton = new ToolStripButton("Copia");
            copyButton.Click += (s, e) =>
            {
                Clipboard.SetText(textBox.Text);
                dropDown.Close();
            };

            dropDown.Items.Add(textBox);
            dropDown.Items.Add(copyButton);
            dropDown.Show(Cursor.Position);
        }

        private async Task<string> GeTemplate(string name, string description)
        {
            string output = string.Empty;
            try
            {
                var tp = await dataContext.Template.Where(x => x.Name == name & x.Description == description).ToListAsync();
                Ptompt_Template ptompt_Template = tp.FirstOrDefault()!;

                output = ptompt_Template.Template;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return output;
        }

        private void GetMetch(string item, out string name, out string description)
        {
            Regex regex = new Regex(@"Nome: (.*?),  Description: (.*)");
            Match match = regex.Match(item);

            name = match.Groups[1].Value;
            description = match.Groups[2].Value;
        }
    }
}
