using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
namespace Vivid.UI.UIWidgets
{
    public class UIButton : UIWidget
    {
        public UIButton(float x, float y, float w, float h, string text, UIWidget root) : base(x, y, w, h, text, root)
        {

        }
        public override void Draw()
        {
            UISys.Skin().DrawButton(this,ButState.Norm);

        }

    }
}
