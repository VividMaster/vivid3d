using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid;
using Vivid.App;
using Vivid.State;
using Vivid.Scene;
using Vivid.Visuals;
using Vivid.UI;
using Vivid.Draw;
using Vivid.UI.UIWidgets;
using Vivid.Import;
using Vivid.Texture;
using Vivid.Input;
using OpenTK;
using Vivid.UI.UISkins;
namespace VividIDE
{
    public static class IDE
    {
        public static UISys UI = null;
    }
    public class VIDE : VAppState
    {

        VTex2D ti;
        UIButton okbut = null;
        public override void InitState()
        {
            VAssImpImp.IPath = "c:/med/";
            ti = new VTex2D("test.png", LoadMethod.Multi);
            IDE.UI = new UISys();
            IDE.UI.ISkin = new SkinNeonBlue();
            okbut = new UIButton(20, 20, 200, 20, "OK", null);
            IDE.UI.Root.AddWidget(okbut);
        }
        public override void Update()
        {
            IDE.UI.Update();
        }
        public override void Render()
        {
            IDE.UI.Render();
            //VPen.Rect(20, 20, 200, 40,new OpenTK.Vector4(1,1,1,1),new OpenTK.Vector4(0,0,0,0));
          //  VPen.Rect(20, 20, 200, 200, ti, Vector4.One, Vector4.Zero);
        //    VPen.Line(20, 20, VInput.MX, VInput.MY, Vector4.One, Vector4.Zero);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VApp e1 = new VApp("Vivid3D - IDE", 1024, 768, false);
            e1.PushState(new VIDE());
            e1.Run();
        }
    }
}
