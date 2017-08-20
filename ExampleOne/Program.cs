using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid;
using OpenTK;
using Vivid.System;
using Vivid.Visuals;
using Vivid.Effect;
using Vivid.State;
using Vivid.Draw;
using Vivid.Scene;
using Vivid.Import;
using Vivid.Material;
using Vivid.Input;
namespace ExampleOne
{
    public class Intro1 : VAppState
    {
        public VCam c1 = null;
        public VSceneGraph sg = null;
        public VSceneNode e1 = null;
        public override void InitState()
        {
            sg = new VSceneGraph();
            e1 = VImport.ImportNode("c:/media/test1.3ds");
            var m1 = new VMaterial();
            m1.LoadTexs("c:/media", "tex1");
            var ee = e1 as VSceneEntity;
            SetMat(ee, m1);
            sg.Add(e1);
            c1 = new VCam();
            sg.Add(c1);
   
            c1.Pos(new Vector3(0, 0, 300), Space.Local);
        
        }
        public void SetMat(VSceneEntity e,VMaterial m)
        {
         
            foreach(var mm in e.Meshes)
            {
                mm.Mat = m;
            }
            foreach(var n in e.Sub)
            {
                SetMat(n as VSceneEntity, m);
            }
        }
        public float lx = 0, ly = 0;
        public float y = 0, x = 0, z = 0;
        public override void Render()
        {
            x = x + VInput.MX - lx;
            y = y + VInput.MY - ly;
            lx = VInput.MX;
            ly = VInput.MY;
            e1.Rot(new Vector3(x,y,z), Space.Local);
            //Console.WriteLine("Render!");
            VPen.Rect(20, 20, 200, 200);
            sg.Render();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            VApp e1 = new VApp("Vivid3D - Example One", 800, 600, false);
            e1.PushState(new Intro1());
            e1.Run(60);

        }
        
     

    }
}
