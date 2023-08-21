using DevExpress.DocumentView.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler.Commands;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Work_Tool.Custom_Controls;
using Work_Tool.Utility;
using Work_Tool.WorkToll_libreria_di_classi;
using System.Diagnostics;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;
using System.IO;
using DevExpress.XtraReports.Design;

namespace Work_Tool.Forms
{
    public partial class Landing_Page : Form
    {
        #region Variables
        private Progetto ActiveProject = new Progetto();
        public DataContext Context { get; }
        public IFormFactory factory { get; }
        private List<Label_> Labels = new List<Label_>();
        public List<Idea> Ideas = new List<Idea>();
        public List<Progetto> Progetti = new List<Progetto>();
        private int carouselcount = 0;
        private List<Task_>? jsonTemporaryLis;
        private Label_? selectedLabel = null;
        //private List<Task_>? gerachiTempList;
        private Task_? temporayPopUpTask;
        private bool tempRunOnDb
        {
            get { return jsonTemporaryLis == null ? true : false; }
        }
        private static readonly string FoldersPath = "C:\\Users\\user\\source\\repos\\Work_Tool\\PrivateFoldersPrj";
        #endregion

        public Landing_Page(DataContext context, IFormFactory formFactory)
        {
            //Services
            this.Context = context;
            this.factory = formFactory;

            InitializeComponent();

            //correggo le stonzate fatte in fase Ui
            CorrezzioneCazzCarusel();

            // Aggiornare I progetti
            //..
            //Tutti i progetti
            Progetti = RetriveAllPrj().Result;

            // Navigation Menu
            checkButton1.Click += this.CheckButton1_Click;
            checkButton1.Text = "Lock ADDs";
            simpleButton1.Click += this.Label_IN_btn;
            simpleButton1.Text = "labels";
            simpleButton2.Click += this.Ideas_IN_btn;
            simpleButton2.Text = "ideas";
            simpleButton3.Click += this.Prompt_Template_in;
            simpleButton3.Text = "Prompt";

            // Retrive active project
            ActiveProject = GetActive().Result;
            Labels = GetAlLables().Result;
            Ideas = RetriveAllIdeas().Result;

            //Labels
            progect_Details1.label1_.Text = "Description";
            progect_Details1.label2_.Text = "Start";
            progect_Details1.label3_.Text = "Estimated End";
            progect_Details1.label4_.Text = "Select Your Base Idea";

            //BottomBtn
            progect_Details1.DropDownList.Text = "Select Idea";
            progect_Details1.DropDownList.Click += this.DropDownList_Click;
            progect_Details1.Resources.Text = "Res_Fold";
            progect_Details1.Resources.Click += this.Resources_Click;
            progect_Details1.PushBtn.Text = "Pusch New Prj"; // need task menagmen
            progect_Details1.PushBtn.Click += this.PushBtn_Click;

            //Carusel  && CaruselTimer
            var w = carusel_Prj_1.center.Width;
            var h = carusel_Prj_1.center.Height;
            carusel_Prj_1.left.AutoSize = false;
            carusel_Prj_1.right.AutoSize = false;
            carusel_Prj_1.left.Size = new Size(Width = (int)(w * 0.7), Height = (int)(h * 0.7));
            carusel_Prj_1.right.Size = new Size(Width = (int)(w * 0.7), Height = (int)(h * 0.7));
            carusel_Prj_1.Resize += this.Carusel_Prj_1_Resize;

            timercarosel.Enabled = true;
            timercarosel.Tick += this.Timercarosel_Tick;

            //timer
            timernotifiche.Enabled = false;
            timernotifiche.Tick += this.Timernotifiche_Tick;
            SetUpLabelList();
            SetUpDetailPage();

            carusel_Prj_1.list.Click += this.List_Click;
            carusel_Prj_1.add.Click += this.Add_Click;

            //Details Btn
            simpleButton5.Click += this.ExecuteFunction; ;

            //tento l'inserimento dei nodi
            if (ActiveProject != null)
                FillTreeView();

            //Aggiungo i Sottomenu
            foreach (StattusTask item in Enum.GetValues(typeof(StattusTask)))
            {
                BarButtonItem statbtn = new BarButtonItem() { Caption = item.ToString() };
                statbtn.ItemClick += this.Statbtn_ItemClick;
                status_popup.AddItem(statbtn);
            }
            task_info_popup.ItemClick += this.Info_PopUp_Click;
            linkcontainer_popup.ItemClick += this.Linkcontainer_popup_ItemClick;
            execute_Function_popUp.ItemClick += this.Execute_Function_popUp_ItemClick;
            Tree_view.NodeMouseDoubleClick += this.Tree_view_NodeMouseDoubleClick;
        }

        #region methods

        private void UpdateThis()
        {
            this.ActiveProject = this.GetActive().Result;
            this.Tree_view.Nodes.Clear();
            SetUpDetailPage();
            this.jsonTemporaryLis = null;
            FillTreeView();
            this.Refresh();
        }
        private void Execute_Function_popUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Ptompt_Template> lisTemplate = GetAllPrompTemp().Result;
            execute_Function_popUp.ClearLinks();

            foreach (Ptompt_Template item in lisTemplate)
            {
                BarButtonItem temp = new BarButtonItem() { Caption = item.Name };
                temp.Tag = item.Template;
                temp.ItemClick += this.Temp_ItemClick_PopUp; ;
                temp.Hint = item.Description;
                execute_Function_popUp.AddItem(temp);
            }

            BarButtonItem addnodes = new BarButtonItem() { Caption = "Add New Nodes" };
            addnodes.Tag = e.Item.Tag;
            addnodes.ItemClick += this.Addnodes_PopUp_ItemClick; ;
            execute_Function_popUp.AddItem(addnodes);
        }
        private void Addnodes_PopUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Task_> newTaskList = new Json_Converter<Task_>(textBox1.Text).ConvertFromTxt();

            List<Task_> completeList = AddNodesToExistingTree(newTaskList, temporayPopUpTask!);

            Tree_view.Nodes.Clear();

            BuildGerarchi(Tree_view.Nodes, completeList);
        }
        private void Temp_ItemClick_PopUp(object sender, ItemClickEventArgs e)
        {
            textBox1.Text = e.Item.Tag.ToString();
            radialMenu1.HidePopup();
        }
        private void Linkcontainer_popup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var x = temporayPopUpTask;
                linkcontainer_popup.ClearLinks();

                foreach (Riferimenti item in temporayPopUpTask!.Riferiemnti)
                {
                    BarButtonItem riflink = new BarButtonItem() { Caption = item.Titolo };
                    riflink.Tag = item.URL;
                    riflink.ItemClick += this.Popuo_Riflink_ItemClick;
                    linkcontainer_popup.AddItem(riflink);
                }

                BarButtonItem resources = new BarButtonItem() { Caption = "Build/Open a dadicated folder" };
                linkcontainer_popup.AddItem(resources);
                resources.Tag = temporayPopUpTask!.Nome;
                resources.ItemClick += this.Resources_ItemClick;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Build A Specific Folder;
        private void Resources_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tempRunOnDb)
                {
                    FoldersBuilder(this.ActiveProject, this.ActiveProject.Tasks.FirstOrDefault(x => x.Nome == e.Item.Tag.ToString()));
                }

                else
                {
                    e.Item.Caption = @"Push The Prj first";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Popuo_Riflink_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Tag is riferimenti.Url
            Process.Start(new ProcessStartInfo(e.Item.Tag.ToString()!) { UseShellExecute = true });
        }
        private List<Task_> AddNodesToExistingTree(List<Task_> newtasks, Task_ relatedtask)
        {
            List<Task_> exisistingTask = tempRunOnDb ? ActiveProject.Tasks : jsonTemporaryLis!;
            var existingCount = exisistingTask.Count;

            foreach (Task_ newtask in newtasks)
            {
                newtask.relazioneIterna += existingCount;
                var sum = newtask.ParentID + existingCount;
                newtask.ParentID = newtask.ParentID == 0 ? (int)relatedtask.relazioneIterna : sum;

                exisistingTask.Add(newtask);
            }

            jsonTemporaryLis = exisistingTask;

            return exisistingTask;
        }
        private void PushBtn_Click1(object? sender, EventArgs e) => throw new NotImplementedException();
        private void UpdateTask_Status(Task_ task, StattusTask status) => throw new NotImplementedException();
        //TreeNore popup
        private void Statbtn_ItemClick(object sender, ItemClickEventArgs e)//evento per i subitem stato, considerare caption
        {
            StattusTask status;

            bool convers = Enum.TryParse(e.Item.Caption, out status);

            if (convers)
            {
                if (temporayPopUpTask!.StattusTask == status)
                    return;
                UpdateTask_Status(temporayPopUpTask!, status);
            }
            else if (!convers)
                Console.WriteLine("Status Update Failed");

        }
        private void Info_PopUp_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                Task_? t = temporayPopUpTask;

                PopUp_For_Tree_Item pop = new PopUp_For_Tree_Item(t!);

                radialMenu1.HidePopup();
                pop.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                var x = ex;
            }
        }
        //Ui Area
        private void DropDownList_Click(object? sender, EventArgs e) // Display All Idea
        {
            foreach (Idea items in Ideas)
            {
                var x = progect_Details1.DropDownList.Items.Add(items);
            }
        }
        private void SetUpCaruselUI(Progetto p, Progect_Details car)
        {
            car.label1_.Text = "Name";
            car.label2_.Text = "Description";
            car.label3_.Text = "Progress";

            car.EditDescription.Text = p.Name;
            car.EditStarData.Text = p.Description;
            car.EditEndData.Text = Project_Manager.CalculateProgres(p).ToString();
        }
        private void CorrezzioneCazzCarusel()
        {
            carusel_Prj_1.left.PushBtn.Visible = false;
            carusel_Prj_1.right.PushBtn.Visible = false;
            carusel_Prj_1.left.DropDownList.Visible = false;
            carusel_Prj_1.right.DropDownList.Visible = false;
            carusel_Prj_1.center.DropDownList.Visible = false;
            carusel_Prj_1.center.Resources.Text = "Res";
            carusel_Prj_1.center.Resources.Click += this.Resources_Click1;
            carusel_Prj_1.center.PushBtn.Text = "Active";
            carusel_Prj_1.center.PushBtn.Click += this.PushBtn_Click1; ;
            carusel_Prj_1.center.label4_.Visible = false;
            carusel_Prj_1.left.Click += this.Carusel_Click;
            carusel_Prj_1.right.Click += this.Carusel_Click;
        }
        private void SetUpProgressBar()
        {
            double progress = ActiveProject.Progress * 100;
            int bars = (int)progress;
            TimeSpan span = DateTime.Now - this.ActiveProject.StarData;
            string formatted = span.Days.ToString();

            string format = $"Running Days: {formatted}        Progress: [                    ] {progress}%";

            progres_textbox.Text = ReplaceSpaces(format, 2 * bars);
        }
        private void FillTreeView()
        {
            if (jsonTemporaryLis != null)
                jsonTemporaryLis = null;

            List<Task_> orderedlist = ActiveProject.Tasks.OrderBy(x => x.ParentID).ToList();

            BuildGerarchi(Tree_view.Nodes, orderedlist);

            //Tree_view.NodeMouseDoubleClick += this.Tree_view_NodeMouseDoubleClick;
        }
        // Services
        private string ReplaceSpaces(string text, int numReplacements)
        {
            return Regex.Replace(text, @"\[([^]]+)\]", match =>
            {
                var insideBrackets = match.Groups[1].Value;
                char[] chars = insideBrackets.ToCharArray();

                int replacedCount = 0;
                for (int i = 0; i < chars.Length && replacedCount < numReplacements; i++)
                {
                    if (chars[i] == ' ')
                    {
                        chars[i] = '_';
                        replacedCount++;
                    }
                }

                return "[" + new string(chars) + "]";
            });
        }
        private void BuildGerarchi(TreeNodeCollection collection, List<Task_> tasklist)
        {
            var x = tasklist;
            int? parentId = tasklist.OrderBy(t => t.ParentID).FirstOrDefault()!.ParentID;

            List<Task_> childitem = tasklist.Where(t => t.ParentID == parentId).ToList();

            foreach (Task_ item in childitem)
            {
                TreeNode newNode = new TreeNode(item.Nome);
                newNode.Tag = item.relazioneIterna;  // Memorizza l'ID del task nel nodo per riferimenti futuri
                collection.Add(newNode);

                BuildChildNodes(newNode, tasklist);
            }

            ////Tento L'utilizzo del popUp
            //Tree_view.NodeMouseDoubleClick += this.Tree_view_NodeMouseDoubleClick;
        }
        private void BuildChildNodes(TreeNode parentNode, List<Task_> tasklist)
        {
            try
            {
                double parentId = (double)parentNode.Tag;  // Recupera l'ID del task dal nodo

                List<Task_> childItems = tasklist.Where(t => t.ParentID == parentId).ToList();

                foreach (Task_ childItem in childItems)
                {
                    TreeNode childNode = new TreeNode(childItem.Nome);
                    childNode.Tag = childItem.relazioneIterna;
                    parentNode.Nodes.Add(childNode);

                    BuildChildNodes(childNode, tasklist);  // Chiamata ricorsiva Sulla Nuova Lista
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        private void FoldersBuilder(Progetto prj, Task_? task = null)
        {
            string path = Path.Combine(FoldersPath, prj.Name);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            if (task != null)
            {
                string innerPath = Path.Combine(path, task.Nome);
                if (!Directory.Exists(innerPath))
                    Directory.CreateDirectory(innerPath);
                else
                    Process.Start(innerPath);
            }
        }
        private void SetUpDetailPage()
        {
            Nome_.Text = ActiveProject.Name;

            //Label
            label4.Text = ActiveProject.Label.Ambit;
            label4.ForeColor = Color.FromName(ActiveProject.Label.LabelColor);

            progect_Details1.EditDescription.Text = ActiveProject.Description;
            progect_Details1.EditStarData.Text = ActiveProject.StarData.Date.ToString();
            progect_Details1.EditEndData.Text = ActiveProject.EstimatedEnd.Date.ToString();

            SetUpProgressBar();
        }
        private void SetUpLabelList()
        {
            foreach (Idea items in Ideas)
            {
                progect_Details1.DropDownList.Items.Add(items);
            }
        }
        #endregion

        #region DB
        private async Task<List<Ptompt_Template>> GetAllPrompTemp()
        {
            return await Context.Template.ToListAsync();
        }
        private async Task<List<Progetto>> RetriveAllPrj()
        {
            List<Progetto> list = new List<Progetto>();
            try
            {
                list = await Context.Progetto.Include(t => t.Tasks).ThenInclude(l => l.Riferiemnti).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
        public async Task<List<Idea>> RetriveAllIdeas()
        {
            try
            {
                return await Context.Ideas.ToListAsync();
            }
            catch (Exception)
            {
                return new List<Idea>()
                {
                    new Idea(){Nome = "TestIdea", Description = "TestDescIdea", Label = Labels.FirstOrDefault()!}
                };
            }
        }
        private async Task<List<Label_>> GetAlLables()
        {
            try
            {
                return await Context.Label.ToListAsync();
            }
            catch (Exception)
            {
                return new List<Label_>() { new Label_() {
                Ambit = "Test_Ambit",
                LabelColor = Color.AntiqueWhite.Name}
                };
            }
        }
        public async Task MakeActive(Progetto progetto)
        {
            foreach (Progetto p in this.Progetti)
            {
                if (p != progetto & p.Status == Status.attivo)
                    p.Status = Status.sospeso;

                if (p == progetto)
                    p.Status = Status.attivo;

                Context.Update(p);
            }

            await Context.SaveChangesAsync();


            UpdateThis();
        }
        private async Task<Progetto> GetActive()
        {
            // Implemento sistema per avere uno ed un solo progetto attivo 
            Progetto progetto;
            try
            {
                progetto = await Context.Progetto.FirstOrDefaultAsync(x => x.Status == Status.attivo);

                if (progetto == null)
                {
                    Context.Progetto.FirstOrDefaultAsync().Result!.Status = Status.attivo;
                    await Context.SaveChangesAsync();
                    progetto = await Context.Progetto.FirstOrDefaultAsync(x => x.Status == Status.attivo)!;
                }

            }
            catch (Exception ex)
            {
                progetto = new Progetto() { Name = "Test", Description = "Test_DEscription", EstimatedEnd = DateTime.Now, Status = Status.attivo };
            }

            return progetto!;
        } // Connette To DB
        private async void PuschPrj(Progetto p)
        {
            try
            {
                foreach (Progetto item in Context.Progetto)
                {
                    if (item.Status == Status.attivo)
                        item.Status = Status.sospeso;
                }
                p.Status = Status.attivo;
                Context.Progetto.Add(p);
                await Context.SaveChangesAsync();

                this.ActiveProject = await GetActive();
                SetUpDetailPage();

                List<Progetto> repo = await Context.Progetto.ToListAsync();

                if (Progetti.Count < repo.Count)
                    Progetti = repo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Events
        //Pusch new prj on db >>>> Label e sbagliato
        private async void PushBtn_Click(object? sender, EventArgs e)
        {
            if (!checkButton1.Checked)
            {
                timernotifiche.Start();
                progect_Details1.PushBtn.Text = "Db Pusch is Loked";
                return;
            }

            try
            {
                Label_ activeLabel = await Context.Label.FirstOrDefaultAsync(x => x.Ambit == label4.Text)!;
                string secription = progect_Details1.EditDescription.Text;
                Progetto p = Project_Manager.BuildPrj(jsonTemporaryLis!, Nome_.Text, activeLabel!, secription);
                PuschPrj(p);

                Progetti = RetriveAllPrj().Result;

                if (jsonTemporaryLis != null)
                    jsonTemporaryLis = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                timernotifiche.Start();
                checkButton1.Text = "Push Error";
                throw;
            }


        }
        //Open Res Folder
        private void Resources_Click1(object? sender, EventArgs e) => throw new NotImplementedException();
        //Make Prj Active
        private void Carusel_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        //Filter prj
        private void Add_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        // open  list of project
        private void List_Click(object? sender, EventArgs e)
        {
            var listOfPrjWindow = factory.CreateListOfPrj(this);
            listOfPrjWindow.ShowDialog();
        }
        //Open Resource Folder
        private void Resources_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        //Pop_Up sui nodi
        private void Tree_view_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode? node = e.Node;
            string st = node!.Text;
            Task_? tz = null;

            if (jsonTemporaryLis != null)
                tz = jsonTemporaryLis!.FirstOrDefault(x => x.Nome == st);

            else if (tz == null)
            {
                tz = ActiveProject.Tasks.FirstOrDefault(x => x.Nome == st);
            }

            if (node != null & tz != null)
            {
                label_Static_Item_popup.Caption = st;
                temporayPopUpTask = tz;
                status_popup.Caption = $"Status : {tz!.StattusTask}";

                radialMenu1.ShowPopup(Cursor.Position);
            }
            else
                Console.WriteLine("TreeNode is null");

        }


        //Per ora puscho la treeview senza passare dal db
        private void ExecuteFunction(object? sender, EventArgs e)
        {
            List<Task_> tasklist = new Json_Converter<Task_>(textBox1.Text).ConvertFromTxt();

            Tree_view.Nodes.Clear();

            foreach (var item in tasklist)
            {
                item.Id = 0;
            }

            jsonTemporaryLis = tasklist;

            BuildGerarchi(Tree_view.Nodes, tasklist);
        }
        private void Carusel_Prj_1_Resize(object? sender, EventArgs e)
        {
            var w = carusel_Prj_1.center.Width;
            var h = carusel_Prj_1.center.Height;
            carusel_Prj_1.left.Size = new Size(Width = (int)(w * 0.7), Height = (int)(h * 0.7));
            carusel_Prj_1.right.Size = new Size(Width = (int)(w * 0.7), Height = (int)(h * 0.7));
        }
        private void Prompt_Template_in(object? sender, EventArgs e)
        {
            var propmptWind = factory.CreatePrompTemplate();
            propmptWind.ShowDialog();
        }
        private void Ideas_IN_btn(object? sender, EventArgs e)
        {
            var ideasWind = factory.CreateIdeasWindow(this);
            ideasWind.ShowDialog();
        }
        private void Label_IN_btn(object? sender, EventArgs e)
        {
            var labelwin = factory.CreateLabel(this);
            labelwin.ShowDialog();
        }
        private void CheckButton1_Click(object? sender, EventArgs e)
        {
            timernotifiche.Start();

            if (checkButton1.Checked)
                checkButton1.Text = "Locked";

            if (!checkButton1.Checked)
                checkButton1.Text = "Unlocked";
        }
        private void Timernotifiche_Tick(object? sender, EventArgs e)
        {
            if (checkButton1.Text != string.Empty)
                checkButton1.Text = string.Empty;

            timernotifiche.Stop();
        }
        private void Timercarosel_Tick(object? sender, EventArgs e)
        {
            if (Progetti.Count > 0)
            {
                int tot = Progetti.Count;
                int index_1 = (carouselcount + 1) % tot; // operatore % >>>> cappa un indice a X
                int index_2 = (carouselcount + 2) % tot;

                SetUpCaruselUI(Progetti[index_2], carusel_Prj_1.left);
                SetUpCaruselUI(Progetti[carouselcount], carusel_Prj_1.center);
                SetUpCaruselUI(Progetti[index_1], carusel_Prj_1.center);
            }
        }
        #endregion

    }
}
