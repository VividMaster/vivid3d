using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
namespace Vivid.Draw
{
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
        public static void SetProj(int x,int y,int w,int h)
        {
            DrawMat = Matrix4.CreateOrthographicOffCenter(x, x + w, y + h, y, 0, 1);
        }
        public static void Bind()
        {
            GL.Color4(ForeCol);
            switch(BlendMod)
            {
                case VBlend.Solid:
                    GL.Disable(EnableCap.Blend);
                    break;
            }
            
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref DrawMat);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

        }
        public static void Release()
        {

        }
        public static void Rect(int x,int y,int width,int height)
        {
            Bind();
            GL.Begin(BeginMode.Quads);
            GL.Vertex2(x, y);
            GL.Vertex2(x + width, y);
            GL.Vertex2(x + width, y + height);
            GL.Vertex2(x, y + height);
            GL.End();
            Release();
        }
        
    }
}
