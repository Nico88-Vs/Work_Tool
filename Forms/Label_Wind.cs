using Microsoft.EntityFrameworkCore;
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
    public partial class Label_Wind : Form
    {
        private readonly DataContext context;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private static List<Label_> list = new List<Label_>();
        

        public Label_Wind(DataContext context)
        {
            InitializeComponent();
            this.context = context;
            button_Crea.Click += this.Button_Crea_Click;
            timer.Interval = 2500;
            timer.Tick += this.Timer_Tick;

            RetriveLabelList();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();
            button_Crea.Text = "crea";
        }
        private async void Button_Crea_Click(object? sender, EventArgs e)
        {
            if (textEdit_Nome.Text != string.Empty)
            {
                bool conteincolor =  context.Label
                    .Where(x => x.LabelColor == colorEdit_DropDown.Color.Name || x.Ambit.ToLower() == textEdit_Nome.Text.ToLower())
                    .Any();

                if (conteincolor)
                {
                    timer.Start();
                    button_Crea.Text = "Ambit or Color arlady exisist";
                }

                else
                {
                    context.Label.Add(new Label_() { Ambit = textEdit_Nome.Text, LabelColor = colorEdit_DropDown.Color.Name });
                    await context.SaveChangesAsync();
                }

                RetriveLabelList();
            }
            else
            {
                timer.Start();
                button_Crea.Text = "Invalid Name";
            }
        }
        private async void RetriveLabelList()
        {
            try
            {
                list = await context.Label.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                timer.Start();
                button_Crea.Text = "DB Error";
            }
        }
    }
}
