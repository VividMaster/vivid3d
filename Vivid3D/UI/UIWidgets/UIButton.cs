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
        public UIButton(float x, float y, float w, float h, string text, UIWidget root) : base(x, y, w, h, text, root)
        {

        }
        public override void OnEnter()
        {
            State = ButState.Hover;
        }
        public override void OnLeave()
        {
            State = ButState.Norm;
        }
        public override void OnMouseDown(UIMouseButton b)
        {
            State = ButState.Press;
        }
        public override void OnMouseUp(UIMouseButton b)
        {
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
