using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    public delegate void SizeChange();
    public class UISplitterH : UIWidget
    {
        public SizeChange SizeAction;
        public UIPanel Left, Right;
        public UIButton Mover;
        public int SplitX = 0;
        public UISplitterH(int x, int y, int w, int h, UIWidget top = null) : base(x, y, w, h, "", top)
        {
            SplitX = w / 2;
            Left = new UIPanel(0, 0, SplitX - 5, h, "Left", this);
            Right = new UIPanel(SplitX + 5, 0, w / 2 - 10, h, "Right", this);
            Mover = new UIButton(SplitX - 5, 0, 10, h, "<>", this);
            Mover.Dragged = (ax, ay) =>
            {
                SplitX += ax;
                Mover.WidX = SplitX;
                Left.WidW = SplitX - 5;
                Right.WidW = w / 2 - 10;
                Right.WidX = SplitX + 5;
                Right.WidW = (WidW - SplitX);
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
