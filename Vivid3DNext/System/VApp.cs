using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Vivid.State;
using Vivid.Draw;
using Vivid.Import;
using OpenTK.Input;
using Vivid.Input;
namespace Vivid.System
{
    public static class AppInfo
    {
        public static int W, H;
        public static bool Full;
        public static string App;
    }
    public class VApp : GameWindow
    {

        private string _Title = "";
        private OpenTK.Graphics.Color4 _BgCol = OpenTK.Graphics.Color4.Black;
        public VStateManager Stater = new VStateManager();
        public void CleanStates()
        {
            Stater = new VStateManager();
        }
        public void PushState(VAppState state)
        {
            Stater.PushState(state);
        }
        public void PopState()
        {
            Stater.PopState();
        }
        public void AddConState(VAppState state)
        {
            Stater.AddConState(state);
        }
        public OpenTK.Graphics.Color4 BgCol
        {
            get { return _BgCol; }
            set { _BgCol = value; }
        }
        public string AppName
        {
            get { return _Title; }
            set { _Title = value;Title = value; }
        }
        public VApp(string app,int width,int height,bool full) : base(width,height,OpenTK.Graphics.GraphicsMode.Default,app,full ? GameWindowFlags.Fullscreen : GameWindowFlags.FixedWindow,DisplayDevice.Default,2,0,OpenTK.Graphics.GraphicsContextFlags.ForwardCompatible)

        {
            _Title = app;
            AppInfo.W = width;
            AppInfo.H = height;
            AppInfo.Full = full;
            AppInfo.App = app;
            VImport.RegDefaults();
         for(int i = 0; i < 32; i++)
            {
                VInput.MB[i] = false;
            }

        }
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            VInput.MX = e.X;
            VInput.MY = e.Y;
            VInput.MZ = e.Mouse.Wheel;
            VInput.MDX = e.XDelta;
            VInput.MDY = e.YDelta;
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.Scissor(0, 0, Width, Height);
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.Texture2D);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.Disable(EnableCap.StencilTest);
            GL.Disable(EnableCap.ScissorTest);
            GL.Disable(EnableCap.Lighting);

            //GL.DepthFunc(DepthFunction.Greater);

            GL.ClearDepth(1.0f);
     
            GL.Enable(EnableCap.DepthTest);
            GL.DepthRange(0, 1);
            GL.DepthFunc(DepthFunction.Less);
        }

        protected override void OnLoad(EventArgs e)
        {
            CursorVisible = true;
            VPen.SetProj(0, 0, Width, Height);


        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Stater.Update();
            VInput.MDX = 0;
            VInput.MDY = 0;
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Title = AppName;
            Title += $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(_BgCol);

           // GL.DepthMask(true);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            Stater.SmartRender();

            SwapBuffers();
        }


    }
}
