using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    
    public class UISplitterV : UIWidget
    {
        public SizeChange SizeAction;
        public UIPanel Top, Bot;
        public UIButton Mover;
        public int SplitY = 0;
        public UISplitterV(int x, int y, int w, int h, UIWidget top = null) : base(x, y, w, h, "", top)
        {
            SplitY = h / 2;
            Top = new UIPanel(0,0, w,SplitY-5, "Top", this);
            Bot = new UIPanel(0, SplitY+5, w, h/2, "Bot", this);
            Mover = new UIButton(0,SplitY - 5, w, 10, "*", this);
            Mover.Dragged = (ax, ay) =>
            {
                SplitY += ay;
                Mover.WidY = SplitY;
                Top.WidH = SplitY - 5;
                Bot.WidH = h / 2 - 10;
                Bot.WidY = SplitY + 5;
                Bot.WidH = (WidH- SplitY);
                if (SizeAction != null)
                {
                    SizeAction();
                }
            };
        }
        public override void Draw()
        {
            // UISys.Skin().DrawRect((int)WidX + SplitX - 5, (int)WidY, 10, (int)WidH, new OpenTK.Vector4(0.8f, 0.8f, 0.8f, 1.0f));

        }
    }
}
