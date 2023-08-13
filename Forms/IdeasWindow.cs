using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using W_Tool_LibreriaClassi;

namespace Work_Tool.Forms
{
    public partial class IdeasWindow : Form
    {
        private readonly DataContext DataContext;
        private List<Idea> ideaslist = new List<Idea>();

        private List<Label_> labels = new List<Label_>();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public IdeasWindow(DataContext context)
        {
            InitializeComponent();
            this.DataContext = context;
            labels = RetriveAlLabls().Result;
            timer.Interval = 2500;
            timer.Tick += this.Timer_Tick;

            //FillIdeas.List
            ideaslist = GetIdeas().Result;

            // Combo Box
            label_DD_list.DrawMode = DrawMode.OwnerDrawFixed;
            label_DD_list.DrawItem += this.Label_DD_list_DrawItem;
            FillCombobox();
        }

        private void Label_DD_list_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            Label_ tiem = (Label_)label_DD_list.Items[e.Index];
            System.Drawing.Color co = GetColor(tiem.LabelColor);

            using (System.Drawing.Brush brusch = new SolidBrush(co))
            {
                e.DrawBackground();
                e.Graphics.DrawString(tiem.Ambit, e.Font!, brusch, e.Bounds);
                e.DrawFocusRectangle();
            }

            if (label_DD_list.SelectedItem != null)
            {
                Label_ l = (Label_)label_DD_list.SelectedItem;
                System.Drawing.Color c = GetColor(l.LabelColor);
                label_DD_list.ForeColor = c;
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            simpleButton_puschIdea.Text = "Pusch Idea";
        }
        private async Task<List<Idea>> GetIdeas()
        {
            try
            {
                return await this.DataContext.Ideas.ToListAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Idea>() { new Idea() };
            }
        }
        private void FillCombobox()
        {
            if (labels.Count > 0)
            {
                foreach (Label_ item in labels)
                {
                    label_DD_list.Items.Add(item);
                }
            }
        }
        private async Task<List<Label_>> RetriveAlLabls()
        {
            List<Label_> list = new List<Label_>();
            try
            {
                list = await DataContext.Label.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                timer.Start();
                simpleButton_puschIdea.Text = "DB Error";
            }
            return list;
        }
        private async void PuschIdea()
        {
            try
            {
                bool any = ideaslist
                    .Where(x => x.Description.ToLower() == textBox_Descrizione.Text.ToLower() || x.Nome.ToLower() == textBox_Nome.Text.ToLower())
                    .Any();
                if (any)
                {
                    timer.Start();
                    simpleButton_puschIdea.Text = "Idea Arlady Exist";
                }
                else
                {
                    Label_ l = label_DD_list.SelectedItem as Label_;

                    if (l == null)
                    {
                        timer.Start();
                        simpleButton_puschIdea.Text = "Select A Valid LAbel";
                    }
                    else
                    {
                        DataContext.Ideas.Add(new Idea() { Nome = textBox_Nome.Text, Description = textBox_Descrizione.Text, Label = l });
                        await DataContext.SaveChangesAsync();
                    }
                }
            }
            catch (Exception)
            {
                timer.Start();
                simpleButton_puschIdea.Text = "DB error";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton_puschIdea_Click(object sender, EventArgs e)
        {
            if (textBox_Descrizione.Text != string.Empty & textBox_Nome.Text != string.Empty)
                PuschIdea();
            else
            {
                timer.Start();
                simpleButton_puschIdea.Text = "Invalid Name or Description";
            }
        }
        private System.Drawing.Color GetColor(string s)
        {
            System.Drawing.Color c = new System.Drawing.Color();
            try
            {
                int argb = Int32.Parse(s, System.Globalization.NumberStyles.HexNumber);
                c = System.Drawing.Color.FromArgb(argb);

            }
            catch (Exception ex)
            {
                bool isKnownColor = Enum.IsDefined(typeof(KnownColor), s);

                if(isKnownColor)
                    c = System.Drawing.Color.FromName(s);
                else
                    Console.WriteLine(ex);
            }
            return c;
        }
    }
}
