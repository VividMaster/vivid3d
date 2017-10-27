using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI
{
    public enum UIMouseButton
    {
        Left,Right,Middle,Fourth,Fifth,Sixth,Seventh,Eighth,Nineth,Tenth,LeftAndRight,RightAndMiddle,LeftAndMiddle
    }
    public class UISys
    {
        public UIWidget Root;
        public UIWidget TopRoot;
        public bool BlurRoot = false;
    }
}
