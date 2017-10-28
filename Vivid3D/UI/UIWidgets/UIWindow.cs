using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI;
namespace Vivid.UI.UIWidgets
{
    public class UIWindow : UIWidget
    {
        public UIWindow(float x, float y, float w, float h, string title, UIWidget top) : base(x, y, w, h, title, top)
        {

        }
    }
}
