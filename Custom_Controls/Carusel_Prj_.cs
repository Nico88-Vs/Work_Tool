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
    public partial class Carusel_Prj_ : UserControl
    {
        public Progect_Details left = new Progect_Details();
        public Progect_Details right = new Progect_Details();
        public Progect_Details center = new Progect_Details();

        public SimpleButton add = new SimpleButton();
        public SimpleButton list = new SimpleButton();
        public Carusel_Prj_()
        {
            InitializeComponent();

            add = simpleButton1;
            list = simpleButton2;

            left = progect_Details1;
            center = progect_Details2;
            right = progect_Details3;
        }
    }
}
