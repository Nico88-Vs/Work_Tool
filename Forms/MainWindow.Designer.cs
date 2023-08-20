using Autofac;
using Microsoft.EntityFrameworkCore;
using Work_Tool.Custom_Controls;
using Work_Tool.Pannels;
using Work_Tool.Utility;

namespace Work_Tool.Forms
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        private readonly DataContext dataContext;
        private readonly IFormFactory factory;
        private Header header;
        private Footer footer;
        private TableLayoutPanel tableLayoutPanel_Row;
        private TableLayoutPanel tableLayoutPanel_Colums;
        private OpenFileDialog openFileDialog;
        private TreeView treeView_Row;

        public MainWindow(DataContext dataContext, IFormFactory container)
        {
            //Declaration
            openFileDialog = new OpenFileDialog();

            //Services Injected
            this.dataContext = dataContext;
            this.factory = container;

            //Setto Le Prop Del Foarm
            this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.Bounds.Size;

            //abilito il listere per il form sugli oggetti
            this.KeyPreview = true;
            this.KeyDown += this.MainWindow_KeyDown;

            // Inizializzo i componenti per le costruzione dal contenitore di Injection
            InitializeComponent();
        }

        #region Windows Form Designer generated code
        private async void InitializeComponent()
        {
            List<Topic> lt = await LoaData();

            List<MainToolComponent> lm = FillMainTooList(lt);

            CreateGrid();

            // Creo I componenti Custom
            footer = new Footer(this);
            header = new Header(this, factory);
            header.btnIdee.Click += this.BtnIdee_Click;
            header.btnTodo.Click += this.BtnDaFare_Click;
            header.propmp_Temp_Btn.Click += this.Propmp_Temp_Btn_Click;  

            //aggiungo un custom colo per vedere la griglia 
            Panel bg_test = new Panel();
            bg_test.BackColor = Color.Violet;
            bg_test.Dock = DockStyle.Fill;

            //Aggiungo La TreeView al pannello
            treeView_Row = new TreeView();
            treeView_Row.Dock = DockStyle.Fill;
            bg_test.Controls.Add(treeView_Row);

            List_Main_Component mainToolComponent = new List_Main_Component(lm);
            foreach (MainToolComponent toolComponent in mainToolComponent.components)
            {
                toolComponent.DoubleClick += this.ToolComponent_DoubleClick;
                toolComponent.innerbtn.Click += this.Innerbtn_Click;   
            }
            mainToolComponent.Dock = DockStyle.Fill;
            mainToolComponent.btnAdd.Click += this.BtnAdd_Click;

            //Li Aggiungo Alla Griglia ___ inizio dalle colonne
            tableLayoutPanel_Colums.Controls.Add(mainToolComponent, 0,0);
            tableLayoutPanel_Colums.Controls.Add(bg_test, 1, 0);
            tableLayoutPanel_Row.Controls.Add(header, 0, 0);
            tableLayoutPanel_Row.Controls.Add(footer, 0, 2);


            Controls.Add(tableLayoutPanel_Row);

            Text = "Organizzazione Lavori";
        }


        private async void Innerbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Control pa = btn.Parent as Control;

            Control nonno = pa.Parent as Control;
            Control gnonno = nonno.Parent as Control;

            MainToolComponent send = gnonno.Parent as MainToolComponent;

            if (send != null)
            {
                int y = await RetriveByNameAnDescription(send.lblName.Text, send.txtDescription.Text);
                List<Topic> list = await GeTreElements(y);
                FillTreeView(list, send.lblName.Text);
            }
        }
        private void TreeView_Row_Click(object sender, EventArgs e) => throw new NotImplementedException();

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Functions
        private void CreateGrid()
        {
            tableLayoutPanel_Colums = new TableLayoutPanel();
            tableLayoutPanel_Colums.ColumnCount = 2;
            tableLayoutPanel_Colums.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel_Colums.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));


            tableLayoutPanel_Row = new TableLayoutPanel();
            tableLayoutPanel_Row.RowCount = 3;
            tableLayoutPanel_Row.RowStyles.Add(new RowStyle(SizeType.Percent, 5f));
            tableLayoutPanel_Row.RowStyles.Add(new RowStyle(SizeType.Percent, 90f));
            tableLayoutPanel_Row.RowStyles.Add(new RowStyle(SizeType.Percent, 5f));

            tableLayoutPanel_Row.Controls.Add(tableLayoutPanel_Colums, 0, 1);

            tableLayoutPanel_Colums.Dock = DockStyle.Fill;
            tableLayoutPanel_Row.Dock = DockStyle.Fill;
        }

        private List<MainToolComponent> FillMainTooList(List<Topic> list)
        {
            List<MainToolComponent> tooList = new List<MainToolComponent>();

            foreach (Topic item in list)
            {
                MainToolComponent comp = new MainToolComponent();
                comp.lblName.Text = item.Subject;
                Color cl = Color.FromName(item.Label.LabelColor);
                comp.picColor.BackColor = cl;
                comp.txtDescription.Text = item.Description;
                tooList.Add(comp);
            }

            return tooList;
        }

        private void AddChildNodes(TreeNode currentNode, int parentId, List<Topic> topics)
        {
            foreach (var topic in topics.Where(t => t.ParentId == parentId))
            {
                TreeNode childNode = new TreeNode(topic.Subject);
                currentNode.Nodes.Add(childNode);
                AddChildNodes(childNode, topic.Id, topics);
            }
        }

        private void FillTreeView(List<Topic> topics, string rootName)
        {
            treeView_Row.Nodes.Clear();
            TreeNode rootNode = new TreeNode(rootName);

            List<Topic> ordered = topics.OrderBy(x => x.ParentId).ToList();

            // Trova e aggiungi tutti i nodi principali al nodo radice.
            foreach (var topic in topics.Where(t => t.ParentId == ordered.First().ParentId))
            {
                TreeNode mainNode = new TreeNode(topic.Subject);
                rootNode.Nodes.Add(mainNode);
                AddChildNodes(mainNode, topic.Id, topics);
            }

            treeView_Row.Nodes.Add(rootNode);
            treeView_Row.ExpandAll();
        }
        #endregion

        #region Events
        private void Propmp_Temp_Btn_Click(object sender, EventArgs e)
        {
            var propmptWind = factory.CreatePrompTemplate();
            propmptWind.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select A Json File";
            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Json_Converter<Topic> converter = new Json_Converter<Topic>(selectedFilePath);
                List<Topic> topics = converter.ConvertFromPath();

                if (topics.Any())
                    PuschData(topics);
                else
                    Console.WriteLine("List is empty");

            }

        }

        private void BtnIdee_Click(object sender, EventArgs e)
        {
            var ideasWindow = factory.CreateIdeasWindow();
            ideasWindow.ShowDialog();
        }

        private void BtnDaFare_Click(object sender, EventArgs e)
        {
            new  Landing_Page(dataContext, factory).ShowDialog();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private async void ToolComponent_DoubleClick(object sender, EventArgs e)
        {
            MainToolComponent send = sender as MainToolComponent;
            int y = await RetriveByNameAnDescription(send.lblName.Text, send.txtDescription.Text);
            List<Topic> list = await GeTreElements(y);
            FillTreeView(list, send.lblName.Text);
        }
        #endregion

        #region DB
        private async void PuschData(List<Topic> topic)
        {
            try
            {
                foreach(Topic topicItem in topic)
                {
                    var debug = await dataContext.AddAsync(topicItem);
                }
                await dataContext.SaveChangesAsync();

                // Ricarico I Dati
                List<Topic> lt = await LoaData();
                List<MainToolComponent> lm = FillMainTooList(lt);
                List_Main_Component mainToolComponent = new List_Main_Component(lm);
                mainToolComponent.Dock = DockStyle.Fill;

                tableLayoutPanel_Colums.Controls.RemoveAt(0);
                tableLayoutPanel_Colums.Controls.Add(mainToolComponent, 0, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task<List<Topic>> LoaData()
        {

            return await dataContext.Topic.Where(i => i.ParentId == null).ToListAsync();
        }

        private async Task<int> RetriveByNameAnDescription(string name, string description)
        {
            Topic output = new Topic();
            try
            {
                output = await dataContext.Topic.Where(x => x.Subject == name && x.Description == description).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return output.Id;
        }

        private async Task<List<Topic>> GeTreElements(int id)
        {
            List<Topic> output = new List<Topic>();
            List<Topic> gt = new List<Topic>();
            List<Topic> db = new List<Topic>();

            db = await dataContext.Topic.ToListAsync();
            gt = await dataContext.Topic.Where(t => t.ParentId == id).ToListAsync();

            while (gt.Count > 0)
            {
                List<Topic> transition = new List<Topic>();

                foreach (var item in gt)
                {
                    output.Add(item);
                };

                foreach (Topic item in gt)
                {
                    var select = db.Where(x => x.ParentId == item.Id).ToList();

                    foreach (var last in select)
                    {
                        transition.Add(last);
                    }

                    gt = transition;
                }
            }

            return output;
        }
        #endregion

    }
}