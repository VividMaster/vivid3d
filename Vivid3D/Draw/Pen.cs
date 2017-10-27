using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Graphics;
using Vivid.Effect;
using Vivid.Texture;
namespace Vivid.Draw
{
    public class VEQuad : VEffect
    {
        public VEQuad() : base("", "drawVS.txt", "drawFS.txt")
        {

        }
        public override void SetPars()
        {
            SetTex("tR", 0);

        }
    }
    public enum VBlend
    {
        Solid,Alpha,Additive,Modulate,ModulateX2,ModulateX4,Subtract,Burn
    }
    public static class VPen
    {
        public static Color4 ForeCol = Color4.White;
        public static Color4 BackCol = Color4.Black;
        public static VBlend BlendMod = VBlend.Solid;
        public static Matrix4 DrawMat = Matrix4.Identity;
        public static Matrix4 PrevMat = Matrix4.Identity;
        public static VEQuad QFX = null;
        public static int qva = 0, qvb = 0;
        public static VTex2D WhiteTex = null;
        public static void InitDraw()
        {
            QFX = new VEQuad();
            GenQuad();
            WhiteTex = new VTex2D("white.png", LoadMethod.Single);
        }
        public static void DrawQuad()
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
        public static void GenQuad()
        {

            qva = GL.GenVertexArray();

            GL.BindVertexArray(qva);

            float[] qd = new float[18];

            qd[0] = -1.0f;
            qd[1] = -1.0f;
            qd[2] = 0.0f;
            qd[3] = 1.0f; qd[4] = -1.0f; qd[5] = 0.0f;
            qd[6] = -1.0f; qd[7] = 1.0f; qd[8] = 0.0f;
            qd[9] = -1.0f; qd[10] = 1.0f; qd[11] = 0.0f;
            qd[12] = 1.0f; qd[13] = -1.0f; qd[14] = 0.0f;
            qd[15] = 1.0f; qd[16] = 1.0f; qd[17] = 0.0f;




            qvb = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, qvb);
            GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(18 * 4), qd, BufferUsageHint.StaticDraw);
            //  GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

        }
        public static void SetProj(int x,int y,int w,int h)
        {
            DrawMat = Matrix4.CreateOrthographicOffCenter(x, x + w, y + h, y, 0, 1);
        }
        public static void Bind()
        {
        //    GL.Color4(ForeCol);
            switch(BlendMod)
            {
                case VBlend.Solid:
                    GL.Disable(EnableCap.Blend);
                    break;
            }
            
          //  GL.MatrixMode(MatrixMode.Projection);
          //  GL.LoadMatrix(ref DrawMat);
           // GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();

        }
        public static void Release()
        {

        }
        public static void Rect(int x,int y,int width,int height)
        {
            Bind();
           // GL.Begin(BeginMode.Quads);
           // GL.Vertex2(x, y);
            //GL.Vertex2(x + width, y);
            //GL.Vertex2(x + width, y + height);
            //GL.Vertex2(x, y + height);
            //GL.End();
            Release();
        }
        
    }
}
