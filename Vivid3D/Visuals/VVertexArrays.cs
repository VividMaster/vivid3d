using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Visuals
{
    public class VVertexArrays : VVisualizer
    {
        public int va, vbo, eb, tvbo, nbvo, tanvbo, bivbo;
        public VVertexArrays(int vc,int ic) :base(vc,ic)
        {

        }
        public override void SetData(VVertexData<float> d)
        {
            dat = d;
        }
        public override void SetMesh(VMesh m)
        {
            md = m;
        }
        public override void Final()
        {
            va = GL.GenVertexArray();
            GL.BindVertexArray(va);
            vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(md.Data.Components * 4 * md.NumVertices), md.Data.Data, BufferUsageHint.StaticDraw);


            GL.EnableVertexAttribArray(0);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, md.Data.Components * 4, 0);
            GL.EnableVertexAttribArray(1);
            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, md.Data.Components * 4, 12 * 4);
            GL.BindVertexArray(0);
            GL.DisableVertexAttribArray(0);
            GL.DisableVertexAttribArray(1);

            eb = GL.GenBuffer();

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, eb);
            GL.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(Indices * 4), md.Indices, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        }
        public override void Bind()
        {
            GL.BindVertexArray(va);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, eb);
            GL.EnableVertexAttribArray(0);
            GL.EnableVertexAttribArray(1);


        }
        public override void Release()
        {
            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
        }
        public override void Visualize()
        {
            GL.DrawElements(BeginMode.Triangles, Indices, DrawElementsType.UnsignedInt, 0);

        }
    }
}
