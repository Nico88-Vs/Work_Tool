using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Tool.Pannels
{
    public class Header : Panel
    {
        private readonly Form _container;
        private readonly IFormFactory formFactory;
        private Size minsize = new Size(1000, 100);
        private TableLayoutPanel tableLayoutPanel;
        private ColumnStyle cellStyle = new ColumnStyle(SizeType.Percent, (100/5F));

        public Button btnIdee { get; set; }
        public Button btnTodo { get; set; }
        public Button propmp_Temp_Btn { get; set; }


        public Header(Form container, IFormFactory formFactory)
        {
            _container = container;
            this.formFactory = formFactory;

            // Conroller Base Settings
            Width = _container.Width;
            Height = _container.Height;
            BackColor = Color.Azure;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            MinimumSize = minsize;

            //Layout Pannel Base Settings
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 6;

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / 5F)));
            }
            

            // Logo (immagine rotonda)
            PictureBox logo = new PictureBox();
            logo.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\Work_Tool\\Resources\\done_1.jpg"); // Imposta il percorso dell'immagine
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Size = new Size((int)(Width), (int)(Height));
            logo.Anchor = AnchorStyles.Left;
            logo.Anchor = AnchorStyles.Top;
            //logo.Location = new Point(10, (Height - 50) / 2);
            logo.Region = new Region(new GraphicsPath(new Point[] { new Point(25, 0), new Point(50, 25), new Point(25, 50), new Point(0, 25) }, new byte[] { (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line }));
            tableLayoutPanel.Controls.Add(logo, column:1, row: 0);

            // Bottoni Idee e To_do
            btnIdee = new Button();
            btnIdee.Text = "Idee";
            btnIdee.Size = new Size(100, 30);
            btnIdee.Location = new Point(Width - 220, (Height - 30) / 2);
            btnIdee.MaximumSize = new Size(50, 50);
            btnIdee.MinimumSize = new Size(5, 5);
            btnIdee.Anchor = AnchorStyles.Right;
            btnIdee.Anchor = AnchorStyles.Top;
            tableLayoutPanel.Controls.Add(btnIdee, column: 4, row: 0);


            btnTodo = new Button();
            btnTodo.Text = "Todo";
            btnTodo.Size = new Size((int)(Width * 0.1), (int)(Height * 0.9));
            btnTodo.MaximumSize = new Size(50, 50);
            btnTodo.MinimumSize = new Size(5, 5);
            btnTodo.Location = new Point(Width - 110, (Height - 30) / 2);
            btnTodo.Anchor = AnchorStyles.Right;
            btnTodo.Anchor = AnchorStyles.Top;
            tableLayoutPanel.Controls.Add(btnTodo, column: 5, row: 0);

            propmp_Temp_Btn = new Button();
            btnTodo.Text = "Prom";
            btnTodo.Size = new Size((int)(Width * 0.1), (int)(Height * 0.9));
            btnTodo.MaximumSize = new Size(50, 50);
            btnTodo.MinimumSize = new Size(5, 5);
            btnTodo.Location = new Point(Width - 110, (Height - 30) / 2);
            btnTodo.Anchor = AnchorStyles.Right;
            btnTodo.Anchor = AnchorStyles.Top;
            tableLayoutPanel.Controls.Add(propmp_Temp_Btn, column: 3, row: 0);

            Controls.Add(tableLayoutPanel);
        }
    }
}
