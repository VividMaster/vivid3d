using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    public class UITreeView : UIWidget
    {
        public UIScrollBarV Scroll;
        
        public UITreeView(int x, int y, int w, int h, string title, UIWidget root = null) : base(x, y, w, h, title, root)
        {
            Scroll = new UIScrollBarV(w - 15, 0, h, this);
        }
        public override void Draw()
        {
            UISys.Skin().DrawBox((int)WidX, (int)WidY, (int)WidW,(int)WidH);
            UISys.Skin().DrawBoxText((int)(WidX + WidW / 2 - UISys.Skin().SmallFont.Width(Name) / 2), (int)WidY + 8, Name);

            int dy = 25;
            foreach (var i in ItemRoot.Sub)
            {
                dy=DrawItem(i, dy);
            }
        }
        public int DrawItem(UIItem i,int y,int lc=0)
        {
            int dx = lc * 25 + 5;
            UISys.Skin().DrawBoxText((int)WidX + dx, (int)WidY + y, i.Name);
            y += 25;
            foreach (var si in i.Sub)
            {
                if(si.Open == true)
                {
                    y+=DrawItem(si, y, lc + 1);
                }
            }
            return y;
        }
    }
}
