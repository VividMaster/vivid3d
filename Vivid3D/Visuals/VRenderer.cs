using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
namespace Vivid.Visuals
{
    public class VRenderer
    {
        public List<VRenderLayer> Layers = new List<VRenderLayer>();
        public VRenderer()
        {
            Init();
        }
        public virtual void Init()
        {

        }
        public virtual void Bind(VMesh m)
        {

        }
        public virtual void Render(VMesh m)
        {
            foreach (VRenderLayer rl in Layers)
            {
                rl.Render(m, m.Viz);
            }
        }
        public virtual void Release(VMesh m)
        {

        }
    }
}
