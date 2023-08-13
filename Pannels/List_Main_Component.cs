using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Tool.Custom_Controls;

namespace Work_Tool.Pannels
{
    public class List_Main_Component : Panel
    {
        private FlowLayoutPanel listView = new FlowLayoutPanel();
        public Button btnAdd = new Button();
        public List<MainToolComponent> components;
        private TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

        public List_Main_Component(List<MainToolComponent> _components)
        {
            this.components = _components;

            //proprieta di listview
            listView.WrapContents = true;
            listView.FlowDirection = FlowDirection.LeftToRight;
            listView.AutoScroll = true;
            listView.Dock = DockStyle.Fill;
            listView.BackColor = Color.Violet;
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoSize = true;

            // proprieta bottone 
            btnAdd.AutoSize = true;
            btnAdd.Text = "Uplad New Json";

            foreach (MainToolComponent item in components)
            {
                listView.Controls.Add(item);
            }

            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            tableLayoutPanel.Controls.Add(listView);
            tableLayoutPanel.Controls.Add(btnAdd,0,1);
           
            this.Controls.Add(tableLayoutPanel);
        }
    }
}
