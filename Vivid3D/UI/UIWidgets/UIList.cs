using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Font;

namespace Vivid.UI.UIWidgets
{
    public class UIList : UIWidget
    {
       
        public UIList(int x, int y, int w, int h, string tit = "", UIWidget top = null) : base(x, y, w, h, tit, top)
        {

        }
        public override void Draw()
        {
            UISys.Skin().DrawBox((int)WidX, (int)WidY, (int)WidW, (int)WidH);
            UISys.Skin().DrawBoxText((int)(WidX + WidW / 2 - UISys.Skin().SmallFont.Width(Name) / 2), (int)WidY+8, Name);

        }
       
    }
   
}
