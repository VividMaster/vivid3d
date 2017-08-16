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
namespace ExampleOne
{
    public class Intro1 : VAppState
    {
        public VSceneGraph sg = null;
        public VSceneNode e1 = null;
        public override void InitState()
        {
            sg = new VSceneGraph();
            e1 = VImport.ImportNode("g:/media/3d/test1.3ds");
            sg.Add(e1);

        }
        public override void Render()
        {
            //Console.WriteLine("Render!");
            VPen.Rect(20, 20, 200, 200);
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
