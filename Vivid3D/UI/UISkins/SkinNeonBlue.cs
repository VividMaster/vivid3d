using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
using Vivid.Texture;
using Vivid.Draw;
using Vivid.App;
using Vivid.UI.UIWidgets;
using Vivid.Font;
namespace Vivid.UI.UISkins
{
    public class SkinNeonBlue : UISkin 
    {
        public SkinNeonBlue()
        {

        }
        public override void InitSkin()
        {
            But_Norm = new VTex2D("data/ui/skin/neonblue/button_normal.png", LoadMethod.Multi);
            But_Hover = But_Norm;
            But_Press = But_Norm;
            SmallFont = new VFont("data/font/f1.ttf.vf");
            BigFont = new VFont("data/font/f2.ttf.vf");
        }
        public override void DrawButton(UIButton b,ButState bs)
        {
            VTex2D bi;
            bi = StateImg(bs);
            int fw = SmallFont.Width(b.Name);
            int fh = SmallFont.Height();
            VPen.Rect((int)b.WidX,(int)b.WidY, (int)b.WidW,(int) b.WidH, bi);
            VFontRenderer.Draw(SmallFont, b.Name, (int)(b.WidX + b.WidW / 2 - (fw / 2)),(int)( b.WidY + (b.WidH) / 2 - (fh / 2)));
        }


        
    }
}
