using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;

namespace Vivid.Visuals
{
    public class VRLSimple : VRenderLayer
    {
        public override void Init()
        {
            Viz = new VVSimple();
        }
        public override void Render(VMesh m)
        {
            Console.WriteLine("Rendering mesh:" + m.Name);
            Viz.SetMesh(m);
            Viz.Visualize();
            Console.WriteLine("Rendered.");
        }
    }
}
