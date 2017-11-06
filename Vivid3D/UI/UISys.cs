using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.UI.UIWidgets;
using Vivid.Font;
using OpenTK;
using OpenTK.Input;
namespace Vivid.UI
{
    public enum UIMouseButton
    {
        Left,Right,Middle,Fourth,Fifth,Sixth,Seventh,Eighth,Nineth,Tenth,LeftAndRight,RightAndMiddle,LeftAndMiddle
    }
    public class UISys
    {
        public static Key KeyIn = Key.A;
        public static bool IsKeyIn = false;
        public static int LastStroke = 0;
        public static int NextStroke = 0;
        public static int FirstStrokeWait = 200;
        public static int NextStrokeWait = 30;
        public static List<UISkin> Skins = new List<UISkin>();
        public static UIWidget Active = null;
        public static UIWidget Over = null;
        public static UIWidget Pressed = null;
        public static bool Lock = false;
        public static float AlphaMod = 0.0f;
        public static float DesAlpha = 1.0f;
        public float DA=1.0f;
        public float AA=0.0f;
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

            AA+= (DA - AA) * 0.02f;
            UISys.AlphaMod = AA;
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
