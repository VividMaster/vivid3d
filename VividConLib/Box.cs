using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VividConLib
{
    public partial class Box : UserControl
    {
        public Color BackCol
        {
            get
            {
                return BC;
            }
            set
            {
                BC = value;
                Invalidate();
            }
        }
        private Color BC = Color.DarkBlue;
        public Box()
        {
            InitializeComponent();
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackCol), new Rectangle(0, 0, Width, Height));
        }
    }
}
