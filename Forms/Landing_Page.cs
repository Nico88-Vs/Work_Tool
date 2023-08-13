using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Tool.Forms
{
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            //Tento di aggiungere le skin devexpress
            DevExpress.Skins.SkinManager.EnableFormSkins();

            InitializeComponent();
        }

        private void Header_Tebel_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
