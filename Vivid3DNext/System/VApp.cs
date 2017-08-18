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
        public VApp(string app,int width,int height,bool full) : base(width,height,OpenTK.Graphics.GraphicsMode.Default,app,full ? GameWindowFlags.Fullscreen : GameWindowFlags.FixedWindow,DisplayDevice.Default,3,0,OpenTK.Graphics.GraphicsContextFlags.Default)

        {
            _Title = app;
            AppInfo.W = width;
            AppInfo.H = height;
            AppInfo.Full = full;
            AppInfo.App = app;
            VImport.RegDefaults();
         

        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.Scissor(0, 0, Width, Height);
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.Texture2D);
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.StencilTest);
            GL.Disable(EnableCap.ScissorTest);
            GL.Disable(EnableCap.Lighting);
            GL.Disable(EnableCap.DepthTest);

        }

        protected override void OnLoad(EventArgs e)
        {
            CursorVisible = true;
            VPen.SetProj(0, 0, Width, Height);


        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Stater.Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Title = AppName;
            Title += $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";

            GL.ClearColor(_BgCol);
            GL.ClearDepth(1000.0f);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            Stater.SmartRender();

            SwapBuffers();
        }


    }
}
