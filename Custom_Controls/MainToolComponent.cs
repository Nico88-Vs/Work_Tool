using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tool.Custom_Controls
{
    public class MainToolComponent : UserControl
    {
        public Label lblName = new Label { Text = "Name"};
        public PictureBox picColor = new PictureBox { BackColor = Color.White};
        public TextBox txtDescription = new TextBox { Multiline = true, MaxLength = 100, PlaceholderText = "Description", TextAlign= HorizontalAlignment.Center};
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        private TableLayoutPanel innerLayoutPannel = new TableLayoutPanel();
        public Button innerbtn = new Button();

        public string TopicName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Color LabelColor
        {
            get { return picColor.BackColor; }
            set { picColor.BackColor = value; }
        }

        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }

        public MainToolComponent()
        {
            
            //Scomposizione degli spazi
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnCount = 1;
            innerLayoutPannel.ColumnCount = 2;
            tableLayoutPanel.Dock = DockStyle.Fill;

            //Add controls to second row
            tableLayoutPanel.Controls.Add(txtDescription,0,1);
            foreach (Control item in tableLayoutPanel.Controls)
            {
                item.Dock = DockStyle.Fill;
            }

            //Add new controls first row
            tableLayoutPanel.Controls.Add(innerLayoutPannel,0,0);
            innerLayoutPannel.Controls.Add(lblName ,0,0);
            innerLayoutPannel.Controls.Add(picColor ,1,0);
            foreach (Control item in innerLayoutPannel.Controls)
            {
                item.Dock = DockStyle.Fill;
            }

            picColor.Controls.Add(innerbtn);

            this.Controls.Add(tableLayoutPanel);
        }
    }

}
