using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
using Vivid.Input;
namespace Vivid.UI.UIWidgets
{
    public class UIButton : UIWidget
    {
        public ButState State = ButState.Norm;
        public EventHandler Click;
        public EventHandler Enter;
        public EventHandler Leave;
        public EventHandler Pressed;
        public UIButton(float x, float y, float w, float h, string text, UIWidget root) : base(x, y, w, h, text, root)
        {

        }
        public override void OnEnter()
        {
            if (Enter != null) Enter(this, null);
            State = ButState.Hover;
        }
        public override void OnLeave()
        {
            if (Leave != null) Leave(this, null);
            State = ButState.Norm;
        }
        public override void OnMouseDown(UIMouseButton b)
        {
            State = ButState.Press;

        }
        public override void OnMouseUp(UIMouseButton b)
        {

            if(Click!=null) Click(this, null);
            State = ButState.Norm;
        }
        public override void OnActivate()
        {
        
        }
        public override void OnDeactivate()
        {
         
        }
        public override bool InBounds()
        {
            if(VInput.MX>=WidX)
            {
                if(VInput.MY>=WidY)
                {
                    if(VInput.MX<=WidX+WidW)
                    {
                        if(VInput.MY<=WidY+WidH)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public override void Draw()
        {
       
            UISys.Skin().DrawButton(this);

        }

    }
}
