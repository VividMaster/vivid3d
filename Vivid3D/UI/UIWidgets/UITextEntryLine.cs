using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI.UIWidgets
{
    public class UITextEntryLine : UIWidget
    {
        public UITextEntryLine(int x,int y,int w,string def="",UIWidget top=null) : base(x,y,w,25,def,top)
        {
            Name = "Testing!";
        }
        public override void Draw()
        {
            UISys.Skin().DrawBox((int)WidX, (int)WidY, (int)WidW, (int)WidH);
            UISys.Skin().DrawBoxText((int)WidX + 3, (int)WidY + 3, Name);
        }
    }
}
