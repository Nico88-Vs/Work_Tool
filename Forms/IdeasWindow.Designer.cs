using Microsoft.EntityFrameworkCore;
using Work_Tool.PromptDialog;

namespace Work_Tool.Forms
{
    partial class IdeasWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ListBox listBoxIdeas;
        private List<Idea> ideas = new List<Idea>();
        private readonly DataContext _dataContext;

        public IdeasWindow(DataContext dataContext)
        {
            this._dataContext = dataContext;
            InitializeComponent();
        }

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
            listBoxIdeas = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            this.SuspendLayout();
            // 
            // listBoxIdeas
            // 
            listBoxIdeas.ItemHeight = 15;
            listBoxIdeas.Location = new Point(0, 0);
            listBoxIdeas.Name = "listBoxIdeas";
            listBoxIdeas.Size = new Size(120, 94);
            listBoxIdeas.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Click += this.BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Click += this.BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Click += this.BtnDelete_Click;
            // 
            // IdeasWindow
            // 
            this.ClientSize = new Size(523, 290);
            this.Controls.Add(listBoxIdeas);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnEdit);
            this.Controls.Add(btnDelete);
            this.Name = "IdeasWindow";
            this.Text = "Gestione Idee";
            this.ResumeLayout(false);
        }

        #endregion

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ideaDescription = PromptDialog.PromptDialog.ShowDialog("Inserisci l'idea:", "Nuova Idea");
            if (!string.IsNullOrEmpty(ideaDescription))
            {
                var idea = new Idea(ideaDescription);
                _dataContext.Ideas.Add(idea);
                _dataContext.SaveChanges();
                RefreshIdeasList();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxIdeas.SelectedItem is Idea selectedIdea)
            {
                string newDescription = PromptDialog.PromptDialog.ShowDialog("Modifica l'idea:", "Modifica Idea", selectedIdea.Description);
                if (!string.IsNullOrEmpty(newDescription))
                {
                    selectedIdea.Description = newDescription;
                    RefreshIdeasList();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxIdeas.SelectedItem is Idea selectedIdea)
            {
                ideas.Remove(selectedIdea);
                RefreshIdeasList();
            }
        }

        private void RefreshIdeasList()
        {
            listBoxIdeas.Items.Clear();
            listBoxIdeas.Items.AddRange(_dataContext.Ideas.ToArray());
        }
        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}