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
using OpenTK;
namespace Vivid.UI
{
    public class UISkin
    {
        public VTex2D But_Norm;
        public VTex2D But_Hover;
        public VTex2D But_Press;
        public VFont BigFont = null;
        public VFont SmallFont = null;
        public Vector4 WinBackCol = new Vector4(0, 0, 0.6f, 0.75f);
        public Vector4 WinTitCol = new Vector4(0.4f, 0.4f, 0.4f, 0.8f);
        public Vector4 WinTitTextCol = new Vector4(0.9f, 0.9f, 0.9f, 1.0f);
        public Vector4 WinStatTextCol = new Vector4(0.2f, 0.7f, 0.2f, 1.0f);
        public UISkin()
        {
            InitSkin();
        }
        public virtual void InitSkin()
        {

        }
        public virtual void DrawButton(UIButton w)
        {

        }
        public virtual void DrawWindow(UIWindow w)
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
