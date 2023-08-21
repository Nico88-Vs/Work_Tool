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
    public partial class ListOfPrj : Form
    {
        public List<Progetto> PrjList { get; set; }
        public Landing_Page Landingpage { get; set; }

        public ListOfPrj(Landing_Page landingpage)
        {
            Landingpage = landingpage;
            PrjList = landingpage.Progetti;
            InitializeComponent();
            BuildList();
            listOfPrjListView.View = View.Details;
            listOfPrjListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listOfPrjListView.ItemActivate += this.ListOfPrjListView_ItemActivate;
        }

        private async void ListOfPrjListView_ItemActivate(object? sender, EventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.FocusedItem != null)
                {
                    Progetto p = (Progetto)listView.FocusedItem.Tag;

                    await Landingpage.MakeActive(p);

                    this.Close();
                }
            }
        }

        private void BuildList()
        {
            // Aggiungi la prima colonna
            listOfPrjListView.Columns.Add("Nome del progetto", -2, HorizontalAlignment.Left);

            // Aggiungi la seconda colonna
            listOfPrjListView.Columns.Add("Descrizione", -2, HorizontalAlignment.Left);

            foreach (Progetto progetto in PrjList)
            {
                // Aggiungi un nuovo ListViewItem con due colonne
                ListViewItem item = new ListViewItem(new string[] { progetto.Name, progetto.Description });
                item.Tag = progetto;
                listOfPrjListView.Items.Add(item);
            }
        }
    }
}
