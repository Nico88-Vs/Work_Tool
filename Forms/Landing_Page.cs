using DevExpress.Xpo;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Work_Tool.Custom_Controls;
using Work_Tool.Migrations;
using Work_Tool.WorkToll_libreria_di_classi;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper.ThreadHoppingFiltering;

namespace Work_Tool.Forms
{
    public partial class Landing_Page : Form
    {
        #region Variables
        private Progetto ActiveProject = new Progetto();
        public DataContext Context { get; }
        public IFormFactory factory { get; }
        private List<Label_> Labels = new List<Label_>();
        System.Windows.Forms.ListView popupMenu = new System.Windows.Forms.ListView();
        private List<Idea> Ideas = new List<Idea>();
        private List<Progetto> Progetti = new List<Progetto>();
        private int carouselcount = 0;
        #endregion

        public Landing_Page(DataContext context, IFormFactory formFactory)
        {
            //Services
            this.Context = context;
            this.factory = formFactory;

            InitializeComponent();

            //correggo le stonzate fatte in fase Ui
            CorrezzioneCazzCarusel();

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
            SetUpDetailPage();

            carusel_Prj_1.list.Click += this.List_Click;
            carusel_Prj_1.add.Click += this.Add_Click;
        }

        #region methods
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
            carusel_Prj_1.center.PushBtn.Click += this.PushBtn_Click1;
            carusel_Prj_1.center.label4_.Visible = false;
            carusel_Prj_1.left.Click += this.Carusel_Click;
            carusel_Prj_1.right.Click += this.Carusel_Click;
        }
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
        private void SetUpProgressBar()
        {
            double progress = ActiveProject.Progress * 100;
            int bars = (int)progress;
            TimeSpan span = DateTime.Now - this.ActiveProject.StarData;
            string formatted = span.Days.ToString();

            string format = $"Running Days: {formatted}        Progress: [                    ] {progress}%";

            progres_textbox.Text = ReplaceSpaces(format, 2 * bars);
        }
        private void SetUpDetailPage()
        {
            Name_.Text = ActiveProject.Name;

            //Label
            label4.Text = ActiveProject.Label.Ambit;
            label4.ForeColor = Color.FromName(ActiveProject.Label.LabelColor);

            progect_Details1.EditDescription.Text = ActiveProject.Description;
            progect_Details1.EditStarData.Text = ActiveProject.StarData.Date.ToString();
            progect_Details1.EditEndData.Text = ActiveProject.EstimatedEnd.Date.ToString();

            SetUpLabelList();
            SetUpProgressBar();
        }
        private void SetUpCaruselUI(Progetto p, Progect_Details car)
        {
            car.label1_.Text = "Name";
            car.label2_.Text = "Description";
            car.label3_.Text = "Progress";

            car.EditDescription.Text = p.Name;
            car.EditStarData.Text = p.Description;
            car.EditEndData.Text = CalculateProgres(p).ToString();
        }
        /// <summary>
        /// Trash View Of Pop_Up in  idea List
        /// </summary>
        private void SetUpLabelList()
        {
            foreach (Idea items in Ideas)
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem() { Text = items.Nome, BackColor = Color.FromName(items.Label.LabelColor) };
                popupMenu.Items.Add(item);
            }

            progect_Details1.DropDownList.Controls.Add(popupMenu);
        }
        private double CalculateProgres(Progetto progetto)
        {
            double prog = 0;

            int totalTask = progetto.Tasks.Count;
            int complitedtasks = progetto.Tasks.Where(x => x.StattusTask == StattusTask.completed).ToList().Count;
            prog = complitedtasks / totalTask;

            return prog;
        }
        #endregion

        #region DB
        private async Task<List<Progetto>> RetriveAllPrj()
        {
            List<Progetto> list = new List<Progetto>();
            try
            {
                list = await Context.Progetto.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
        private async Task<List<Idea>> RetriveAllIdeas()
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
        private async Task<Progetto> GetActive()
        {
            try
            {
                return await Context.Progetto.FirstOrDefaultAsync(x => x.Status == status.attivo);
            }
            catch (Exception ex)
            {
                return new Progetto() { Name = "Test", Description = "Test_DEscription", EstimatedEnd = DateTime.Now, Status = status.attivo };
            }
        }
        #endregion

        #region Events
        // Make Active a Project
        private void PushBtn_Click1(object? sender, EventArgs e) => throw new NotImplementedException();
        //Open Res Folder
        private void Resources_Click1(object? sender, EventArgs e) => throw new NotImplementedException();
        //Make Prj Active
        private void Carusel_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        //Filter prj
        private void Add_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        // open  list of project
        private void List_Click(object? sender, EventArgs e) => throw new NotImplementedException();
        //Open Resource Folder
        private void Resources_Click(object? sender, EventArgs e) => throw new NotImplementedException();
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
            var ideasWind = factory.CreateIdeasWindow();
            ideasWind.ShowDialog();
        }
        private void Label_IN_btn(object? sender, EventArgs e)
        {
            var labelwin = factory.CreateLabel();
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
        private void PushBtn_Click(object? sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                return;
                //manca una notifica
            }
        }
        #endregion
    }
}
