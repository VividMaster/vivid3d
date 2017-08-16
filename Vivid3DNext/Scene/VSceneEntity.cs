using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using Vivid.Visuals;
namespace Vivid.Scene
{
    public class VSceneEntity : VSceneNode
    {
        public VRenderer Renderer = null;
        public List<VMesh> Meshes = new List<VMesh>();

        public void AddMesh(VMesh mesh)
        {
            Meshes.Add(mesh);
        }
        public void Clean()
        {
            Meshes = new List<VMesh>();
            Renderer = null;
        }
        public override void Present()
        {
            Bind();
            PreRender();
            Render();
            PostRender();
            Release();
        }
        /// <summary>
        /// To be called AFTER data asscoiation.
        /// </summary>
        public virtual void Init()
        {

        }
        public virtual void Bind()
        {

        }
        public virtual void PreRender()
        {

        }
        public virtual void Render()
        {

        }
        public virtual void PostRender()
        {

        }
        public virtual void Release()
        {

        }
    }
}
