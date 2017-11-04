using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
using OpenTK;
namespace Vivid.UI.UIWidgets
{
    public class UIWindow : UIWidget
    {
        private UIDragZone titleDrag;
        private UIDragZone sizeDrag;
        private UIDragZone rightDrag;
        private UIDragZone leftDrag;
        private UIDragZone botDrag;
        public float Alpha = 0.6f;
        public Vector4 DragCol = new Vector4(0.4f, 0.4f, 0.4f, 0.4f); 
        public UIWindow(int x, int y, int w, int h, string title, UIWidget top=null) : base(x, y, w, h, title, top)
        {
            titleDrag = new UIDragZone(0, 0, (int)WidW, UISys.Skin().TitleHeight, this);
            sizeDrag = new UIDragZone((int)WidW - 15, (int)WidH - 15, 15, 15, this);
            botDrag = new UIDragZone(0, (int)WidH - 10, (int)WidW-15, 10, this);
            rightDrag = new UIDragZone((int)WidW - 10, UISys.Skin().TitleHeight + 1, 10, (int)WidH - 15 - UISys.Skin().TitleHeight, this);
            leftDrag = new UIDragZone(0, UISys.Skin().TitleHeight + 1, 10, (int)WidH - UISys.Skin().TitleHeight - 2, this);
            EnableScissorTest = true;
        }
        public override void Resized()
        {
            titleDrag.WidW = WidW;
            sizeDrag.LocX = WidW - 15;
            sizeDrag.LocY = WidH - 15;
            botDrag.WidW = WidW - 15;
            botDrag.LocY = WidH - 10;
            rightDrag.LocX = WidW - 10;
            rightDrag.WidH = WidH - 15 - UISys.Skin().TitleHeight;
            leftDrag.WidH = WidH - UISys.Skin().TitleHeight - 2;
            //Console.WriteLine("Resized!");
        }
        public override void Draw()
        {
            UISys.Skin().DrawWindow(this);
            UISys.Skin().DrawRect((int)WidX + (int)WidW - 15, (int)WidY + (int)WidH - 15, 15, 15,DragCol);
            UISys.Skin().DrawRect((int)WidX, (int)WidY+UISys.Skin().TitleHeight + 1, 10, (int)WidH - UISys.Skin().TitleHeight - 2,DragCol);
            UISys.Skin().DrawRect((int)WidX, (int)WidY+(int)WidH - 10, (int)WidW - 15, 10,DragCol);
            UISys.Skin().DrawRect((int)WidX + (int)WidW - 10, (int)WidY + UISys.Skin().TitleHeight + 1, 10, (int)WidH - UISys.Skin().TitleHeight - 16,DragCol);
        }
        public override void Update()
        {
            //Console.WriteLine("X:" + titleDrag.DraggedX + " Y:" + titleDrag.DraggedY);
            
            Move(titleDrag.DraggedX, titleDrag.DraggedY);
            Resize(sizeDrag.DraggedX, sizeDrag.DraggedY);
            Resize(rightDrag.DraggedX, 0);
            Resize(0, botDrag.DraggedY);
            Move(leftDrag.DraggedX, 0);
            Resize(-leftDrag.DraggedX, 0);

        }
    }
}
