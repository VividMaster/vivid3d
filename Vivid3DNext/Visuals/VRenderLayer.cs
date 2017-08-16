using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
namespace Vivid.Visuals
{
    public class VRenderLayer
    {
        public VVisualizer Viz = null;
        public VRenderLayer()
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

        }
        public virtual void Release(VMesh m)
        {

        }
    }
}
