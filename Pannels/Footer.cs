using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Tool.Pannels
{
    public class Footer : Panel
    {
        private readonly Form _container;
        private Size minsize = new Size(1000, 100);


        public Footer(Form container)
        {
            this._container = container;

            Width = _container.Width;
            Height = _container.Height;
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MinimumSize = minsize;
            BackColor = Color.Green;
        }
    }
}
