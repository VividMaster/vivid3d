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
    public partial class InfoBox: UserControl
    {
        public string Header
        {
            get;
            set;
        }
        public string Info
        {
            get;
            set;
        }
        public InfoBox()
        {
            InitializeComponent();
        }

        private void InfoBox_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawString(Header, Font, Brushes.DarkBlue, 5, 5);
            g.DrawString(Info, Font, Brushes.Black, new RectangleF(5, 25, Width - 10, Height - 30));

        }
    }
}
