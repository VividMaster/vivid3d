using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace Vivid.Visuals
{
    public class VVSimple : VVisualizer
    {
        public VVertexData<float> dat = null;
        public VMesh md = null;
        public override void SetData(VVertexData<float> d)
        {
            dat = d;
        }
        public override void SetMesh(VMesh m)
        {
            md = m;
        }
        public override void Visualize()
        {
            
            GL.Begin(BeginMode.Triangles);
            var v = md.GetVerts();
          
            for(int i = 0; i < md.NumIndices; i += 3)
            {
                GL.Vertex3(v.)
            }

            GL.End();
        }
    }
}
