using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid;
using OpenTK;
using Vivid.App;
using Vivid.Visuals;
using Vivid.Effect;
using Vivid.State;
using Vivid.Draw;
using Vivid.Scene;
using Vivid.Import;
using Vivid.Material;
using Vivid.Input;
using Vivid.Lighting;
using Vivid.PostProcess;
using Vivid.PostProcess.Processes;
using Vivid.Enviro;
using Vivid.Texture;
namespace ExampleOne
{
    public class Intro1 : VAppState
    {
        public VCam c1 = null;
        public VSceneGraph sg = null;
        public VSceneNode e1 = null;
        public VLight l1;
        public VPostProcessRenderer PR;
        public VSceneNode e2 = null;
        public VEnvRenderer ER = null;
        bool first = true;
        public override void InitState()
        {
            VAssImpImp.IPath = "c:/med/";
            ER = new VEnvRenderer(512, 512);
            PR = new VPostProcessRenderer(512,512);
           // PR.Add(new VPPBlur());
            sg = new VSceneGraph();
            PR.Scene = sg;
            ER.Scene = sg;

            e1 = VImport.ImportNode("c:/Media/dwarf2.b3d"); //file of 3d model to load.
            e1.LocalScale = new Vector3(1, 1, 1);
            
            var m1 = new VMaterial();
            m1.TCol = new VTex2D("c:/Media/tex1_c.png",LoadMethod.Single); // texture to load 
            m1.TEnv = VTextureUtil.LoadCubeMap("c:/Media/cm1.png.cube"); // cubemap to load. use cubeconvert to convert.
            //m2.TEnv = ER.FB.Cube;
            var ee = e1 as VSceneEntity;
            //var ee2 = e2 as VSceneEntity; //building project atm.
            SetMat(ee, m1);

           // SetMat(ee2, m2);
            sg.Add(e1);
           // sg.Add(e2);

            c1 = new VCam();
            sg.Add(c1);
            l1 = new VLight();
            l1.Pos(new Vector3(0, 40, 0), Space.Local);
            c1.Pos(new Vector3(0, 0,300), Space.Local);
            c1.LookAt(Vector3.Zero, new Vector3(0, 1, 0));
            sg.Add(l1);
            //e1.Pos(new Vector3(0, -30, 0), Space.Local);
           // e2.Pos(new Vector3(0, 20, 0), Space.Local);

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
        public float px, pz, pa=0;
        public override void Render()
        {
            pa = pa + 3;
            px = (float)Math.Cos((double)MathHelper.DegreesToRadians(pa)) * 250;
            pz = (float)Math.Sin((double)MathHelper.DegreesToRadians(pa)) * 250;
            if (VInput.KeyIn(OpenTK.Input.Key.W))
            {
                c1.Move(new Vector3(0, 0, -1), Space.Local);
            }
            if (VInput.KeyIn(OpenTK.Input.Key.A))
            {
                c1.Move(new Vector3(-1, 0, 0), Space.Local);
            }
            if (VInput.KeyIn(OpenTK.Input.Key.D))
            {
                c1.Move(new Vector3(1, 0, 0), Space.Local);
            }
            if(VInput.KeyIn(OpenTK.Input.Key.S))
            {
                c1.Move(new Vector3(0, 0, 1),Space.Local);
            }
            if(first)
            {
                lx = VInput.MX;
                ly = VInput.MY;
                first = false;
            }
            x =  VInput.MX - lx;
            y = VInput.MY - ly;
            lx = VInput.MX;
            ly = VInput.MY;
            if (Math.Abs(x) > 15) x = 0;
            if (Math.Abs(y) > 15) y = 0;
            //if (VInput.KeyIn(OpenTK.Input.Key.Space))
            // {

          //  c1.LookAt(Vector3.Zero);
            l1.Diff = new Vector3(5, 5, 5);
               e1.Turn(new Vector3(y*0.6f, x*0.6f, 0), Space.Local);
           // }
                //c1.Turn(new Vector3(y, x, 0), Space.Local);
            //1.Rot(new Vector3(x,y,z), Space.Local);
            l1.Pos(new Vector3(px, 80, pz), Space.Local);
            //Console.WriteLine("Render!");
           // VPen.Rect(20, 20, 200, 200);
            // sg.Render();
          //  ER.Render();

           PR.Render();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            VApp e1 = new VApp("Vivid3D - Example One", 800, 600, false);
            e1.PushState(new Intro1());
            e1.Run();

        }
        
     

    }
}
