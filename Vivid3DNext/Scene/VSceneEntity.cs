using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using Vivid.Visuals;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace Vivid.Scene
{
    public class VSceneEntity : VSceneNode
    {
        public VRenderer Renderer = null;
        public List<VMesh> Meshes = new List<VMesh>();
        public override void Init()
        {
            Renderer = new VRendererSimple();
        }
        public void AddMesh(VMesh mesh)
        {
            Meshes.Add(mesh);
        }
        public void Clean()
        {
            Meshes = new List<VMesh>();
            Renderer = null;
        }
        public override void Present(VCam c)
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref c.ProjMat);
            GL.MatrixMode(MatrixMode.Modelview);
            Matrix4 mm = Matrix4.Identity;
            mm = c.CamWorld;
            mm = World * mm;
            GL.LoadMatrix(ref mm);

            Bind();
            PreRender();
            Render();
            PostRender();
            Release();
            foreach(var s in Sub)
            {
                s.Present(c);
            }
        }
        /// <summary>
        /// To be called AFTER data asscoiation.
        /// </summary>
   
        public virtual void Bind()
        {

        }
        public virtual void PreRender()
        {
          
        }
        public virtual void Render()
        {
            foreach(var m in Meshes)
            {
                Renderer.Render(m);
            }
        }
        public virtual void PostRender()
        {

        }
        public virtual void Release()
        {

        }
    }
}
