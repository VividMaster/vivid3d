using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Texture;
using Vivid.App;
using Vivid.Draw;
using Vivid.UI.UIWidgets;
using Vivid.Font;
namespace Vivid.UI
{
    public class UISkin
    {
        public VTex2D But_Norm;
        public VTex2D But_Hover;
        public VTex2D But_Press;
        public VFont BigFont = null;
        public VFont SmallFont = null;
        public UISkin()
        {
            InitSkin();
        }
        public virtual void InitSkin()
        {

        }
        public virtual void DrawButton(UIButton w,ButState bs)
        {

        }
        public VTex2D StateImg(ButState bs)
        {
            VTex2D bi = null;
            switch (bs)
            {
                case ButState.Norm:
                    bi = But_Norm;
                    break;
                case ButState.Hover:
                    bi = But_Hover;
                    break;
                case ButState.Press:
                    bi = But_Press;
                    break;
            }

            return bi;
        }
    }
    public enum ButState
    {
        Norm,Hover,Press
    }
}
