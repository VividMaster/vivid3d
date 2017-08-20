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
         
        }
        public override void Render(VMesh m,VVisualizer v)
        {
          
            v.SetMesh(m);
            v.Visualize();
           
        }
    }
}
