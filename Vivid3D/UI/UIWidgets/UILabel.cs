using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    public class UILabel : UIWidget
    {
        public UILabel(int x, int y, string text, UIWidget top = null) : base(x, y, 0, 0, text, top)
        {
            Console.WriteLine("Top:" + top.Name);
        }
        public override void Draw()
        {

            UISys.Skin().DrawText((int)WidX, (int)WidY, Name);
        }
    }
}
