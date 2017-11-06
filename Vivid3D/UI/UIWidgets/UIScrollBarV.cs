using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    public class UIScrollBarV : UIWidget
    {
        public UIButton Up, Down, Slide;
        public int Current = 0;
        public int MaxValue = 0;
        public UIScrollBarV(int x, int y, int h, UIWidget root = null) : base(x, y, 15, h, "", root)
        {

            Slide = new UIButton(0, 15, 15, WidH - 30, "*", this);
            Up = new UIButton(0, 0, 15, 15, "/\\",this);
            Down = new UIButton(0, WidH - 15, 15, 15, "\\/", this);
        }
    }
}
