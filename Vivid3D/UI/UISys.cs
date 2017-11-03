using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI.UIWidgets;
using Vivid.Font;
namespace Vivid.UI
{
    public enum UIMouseButton
    {
        Left,Right,Middle,Fourth,Fifth,Sixth,Seventh,Eighth,Nineth,Tenth,LeftAndRight,RightAndMiddle,LeftAndMiddle
    }
    public class UISys
    {
        public static List<UISkin> Skins = new List<UISkin>();
        public static UIWidget Active = null;
        public static UIWidget Over = null;
        public static UIWidget Pressed = null;

    
        public static void PushSkin(UISkin s)
        {
            Skins.Add(s);
        }
        public static void PopSkin()
        {
            if (Skins.Count > 0)
            {
                Skins.Remove(Skins[Skins.Count - 1]);
            }
        }
        public static UISkin Skin()
        {
            if (Skins.Count == 0) return null;
            return Skins[Skins.Count - 1];
        }
        public UISkin ISkin = null;
        public UIWidget Root;
        public UIWidget TopRoot;
        public bool BlurRoot = false;
        public void BeginDesign()
        {
            PushSkin(ISkin);
        }
        public void EndDesign()
        {
            PopSkin();
        }
        public UISys()
        {
            Root = new UIGroup();
        }
        public void Add(UIWidget w)
        {
            Root.AddWidget(w);
        }
        public void Update()
        {
            PushSkin(ISkin);
            Root.OnUpdate();
            Root.UpdateAll();
            PopSkin();

        }
        public void Render()
        {
            PushSkin(ISkin);
            Root.OnDraw();
            PopSkin();
        }
    }
}
