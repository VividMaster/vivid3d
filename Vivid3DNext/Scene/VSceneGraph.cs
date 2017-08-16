using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.Scene
{
    public class VSceneGraph
    {
        public List<VSceneNode> Nodes = new List<VSceneNode>();
        public List<VCam> Cams = new List<VCam>();
        public virtual void Add(VCam c)
        {
            Cams.Add(c);
        }
        public virtual void Add(VSceneNode n)
        {
            Nodes.Add(n);
        }
        public virtual void Clean()
        {
            Nodes.Clear();
        }
        public virtual void Bind()
        {

        }
        public virtual void Release()
        {

        }
        public virtual void Render()
        {
            foreach(var c in Cams)
            {
                foreach(var n in Nodes)
                {
                    n.Render(c);
                }
            }
        }
    }
}
