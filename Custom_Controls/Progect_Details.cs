using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tool.Custom_Controls
{
    public partial class Progect_Details : UserControl
    {
        public DropDownButton DropDownList;
        public Button PushBtn;
        public Button Resources;
        public TextEdit EditDescription;
        public TextEdit EditStarData;
        public TextEdit EditEndData;
        public Label label3_ = new Label();
        public Label label2_ = new Label();
        public Label label1_ = new Label();
        public Label label4_ = new Label();   

        public Progect_Details()
        {
            InitializeComponent();

            label4_ = label4;
            label1_ = label1;
            label2_ = label2;
            label3_ = label3;
            DropDownList = dropDownButton1;
            PushBtn = button2;
            Resources = button1;
            EditDescription = textEdit1;
            EditStarData = textEdit2;
            EditEndData = textEdit3;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void tablePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void stackPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
