using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Scene;
using Vivid.Data;
using Vivid.Material;
using Vivid.Effect;
using Vivid.FrameBuffer;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.PostProcess
{
    public class VPostProcessRenderer
    {
        public VSceneGraph Scene = null;
        public List<VPostProcess> Processes = new List<VPostProcess>();
        public VFrameBuffer FB = null;
        public VFrameBuffer FB2 = null;
        public int IW, IH;
        public VEQuadR QFX = null;
        public VPostProcessRenderer(int w,int h)
        {
            IW = w;
            IH = h;
            FB = new VFrameBuffer(w, h);
            FB2 = new VFrameBuffer(w, h);
            QFX = new VEQuadR();
            GenQuad();
        }
        public void SetScene(VSceneGraph s)
        {
            Scene = s;
        }
        public void Add(VPostProcess vp)
        {

            Processes.Add(vp);

        }
        public void Render()
        {
             FB.Bind();
              Scene.Render();
               FB.Release();
            //GL.DrawBuffer(DrawBufferMode.Back);
            foreach(var p in Processes)
            {
                FB2.Bind();
                p.Bind(FB.BB);
                p.Render(FB.BB);
                p.Release(FB.BB);
                FB2.Release();
                var ob = FB;
                FB = FB2;
                FB2 = ob;

            }
          //  GL.Viewport(0, 0, 1024, 768);
            DrawQuad();
        }
        public int qva = 0, qvb = 0;
        public void DrawQuad()
        {
           FB.BB.Bind(0);

            QFX.Bind();

            GL.BindVertexArray(qva);
        
            GL.BindBuffer(BufferTarget.ArrayBuffer, qvb);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);

            GL.DrawArrays(PrimitiveType.Triangles, 0, 6);

            GL.DisableVertexAttribArray(0);
           // GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            QFX.Release();

            FB.BB.Release(0);
        }
        public void GenQuad()
        {

            qva = GL.GenVertexArray();

            GL.BindVertexArray(qva);

            float[] qd = new float[18];

            qd[0] = -1.0f;
            qd[1] = -1.0f;
            qd[2] = 0.0f;
            qd[3] = 1.0f;qd[4] = -1.0f;qd[5] = 0.0f;
            qd[6] = -1.0f;qd[7] = 1.0f;qd[8] = 0.0f;
            qd[9] = -1.0f;qd[10] = 1.0f;qd[11] = 0.0f;
            qd[12] = 1.0f;qd[13] = -1.0f;qd[14] = 0.0f;
            qd[15] = 1.0f;qd[16] = 1.0f;qd[17] = 0.0f;


    
            
            qvb=GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer,qvb);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(18 * 4), qd, BufferUsageHint.StaticDraw);
          //  GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

        }
    }
    public class VEQuadR : VEffect
    {
        public VEQuadR() : base("","passVS.txt","passFS.txt")
        {

        }
        public override void SetPars()
        {
            SetTex("tR", 0);
            
        }
    }
}
