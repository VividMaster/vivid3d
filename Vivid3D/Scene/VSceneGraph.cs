using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Lighting;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Scene
{
    public class VSceneGraph
    {
        public List<VSceneNode> Nodes = new List<VSceneNode>();
        public List<VCam> Cams = new List<VCam>();
        public List<VLight> Lights = new List<VLight>();
        public VCam CamOverride = null;
        public virtual void Add(VCam c)
        {
            Cams.Add(c);
        }
        public virtual void Add(VLight l)
        {
            Lights.Add(l);
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
        public virtual void RenderDepth()
        {
            GL.ClearColor(new OpenTK.Graphics.Color4(1.0f, 1.0f, 1.0f, 1.0f));
            GL.Clear(ClearBufferMask.ColorBufferBit);
            if (CamOverride != null)
            {
                foreach (var n in Nodes)
                {
                    n.PresentDepth(CamOverride);
                }
            } else
                foreach (var c in Cams)
                {

                    foreach (var n in Nodes)
                    {
                        n.PresentDepth(c);
                    }
                }
        }

        public virtual void Render()
        {
            if (CamOverride != null)
            {
                foreach (var l in Lights)
                {
                    VLight.Active = l;
                    foreach (var n in Nodes)
                    {
                        n.Present(CamOverride);
                    }
                }
            }
            else
            {
                foreach (var c in Cams)
                {
                    foreach (var l in Lights)
                    {
                        VLight.Active = l;
                        foreach (var n in Nodes)
                        {
                            n.Present(c);
                        }
                    }
                }
            }

        }
    }
}
