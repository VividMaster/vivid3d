using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Effect;
using Vivid.Data;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Visuals
{
    public class VRLDepth : VRenderLayer
    {
        public VEDepth fx = null;
        public override void Init()
        {
            fx = new VEDepth();
        }
        public override void Render(VMesh m, VVisualizer v)
        {
            
           // m.Mat.Bind();
            fx.Bind();
            v.SetMesh(m);
            v.Bind();
            v.Visualize();
            v.Release();
            fx.Release();
            //m.Mat.Release();
        }
    }
}
