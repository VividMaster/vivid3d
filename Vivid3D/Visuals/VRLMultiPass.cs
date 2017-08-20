using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using Vivid.Effect;
namespace Vivid.Visuals
{
    public class VRLMultiPass : VRenderLayer
    {
        public VEMultiPass fx = null;
        public override void Init()
        {
            fx = new VEMultiPass();
        }
        public override void Render(VMesh m, VVisualizer v)
        {

            m.Mat.Bind();
            fx.Bind();
            v.SetMesh(m);
            v.Bind();
            v.Visualize();
            v.Release();
            fx.Release();
            m.Mat.Release();
        }
    }
}
