using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraMap.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Tool.WorkToll_libreria_di_classi;

namespace Work_Tool.Forms
{
    public partial class PopUp_For_Tree_Item : Form
    {
        public Task_ RelatedTask { get; }
        public string? outPut { get; set; }

        public PopUp_For_Tree_Item(Task_ relatedTask)
        {
            InitializeComponent();
            this.RelatedTask = relatedTask;
            BuildListview();
            listView1.ItemActivate += this.ListView1_ItemActivate;
        }

        private void ListView1_ItemActivate(object? sender, EventArgs e)
        {
            radialMenu1.ShowPopup(Cursor.Position);
            if (sender!.Equals(listView1.Items[0]))
                outPut = listView1.Items[0].Text;
        }

        private void BuildListview()
        {
            listView1.Items.Add($"Nome : {RelatedTask.Nome}");
            listView1.Items.Add($"Descrizione : {RelatedTask.Description}");
            listView1.Items.Add($"Status : {RelatedTask.StattusTask.ToString()}");
            listView1.Items.Add($"Tips : {RelatedTask.Suggerimenti}");
            listView1.Items.Add($"Exercise : {RelatedTask.Esercizi}");

            this.Size = listView1.Size;
        }
    }
}
