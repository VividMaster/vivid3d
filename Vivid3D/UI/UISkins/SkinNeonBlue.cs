using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
using Vivid.Texture;
using Vivid.Draw;
using Vivid.App;

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
        }
        public override void DrawButton(float x, float y,float w,float h, ButState bs)
        {
            VTex2D bi;
            bi = StateImg(bs);

            VPen.Rect((int)x,(int) y, (int)w,(int) h, bi);
        }

        
    }
}
