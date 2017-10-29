using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Draw;
using Vivid.Texture;
namespace Vivid.Font
{
    public class VFontRenderer
    {

        public static void Draw(VFont font,string text,int x,int y)
        {
            int dx = x;
            VPen.BlendMod = VBlend.Alpha;
            foreach(Char c in text)
            {
                VGlyph cg = font.Glypth[(int)c];
                VPen.Rect(dx, y, cg.W, cg.H, cg.Img);
                dx += cg.W;
            }
        }

    }
}
