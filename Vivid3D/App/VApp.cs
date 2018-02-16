using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using Vivid.State;
using Vivid.Draw;
using Vivid.Import;
using OpenTK.Input;
using Vivid.Input;
namespace Vivid.App
{
    public static class AppInfo
    {
        public static int W, H;
        public static bool Full;
        public static string App;
        public static int RW, RH;
    }
    public class VForm : VApp
    {
        public void SetSize(int w,int h)
        {
            AppInfo.W = w;
            AppInfo.H = h;
            AppInfo.RW = w;
            AppInfo.RH = h;
            GL.Viewport(0, 0,w,h);
            GL.Scissor(0, 0, w, h);
            VPen.SetProj(0, 0, w, h);
        }
         public void Set(int w,int h)
        {
            GL.ClearColor(System.Drawing.Color.AliceBlue);
            GL.Enable(EnableCap.DepthTest);
            AppInfo.W = w;
            AppInfo.H = h;
            AppInfo.RW = w;
            AppInfo.RH = h;
            AppInfo.Full = false;
            AppInfo.App = "GLApp";
            VImport.RegDefaults();
            for (int i = 0; i < 32; i++)
            {
                VInput.MB[i] = false;
            }
            VPen.InitDraw();
            VInput.InitInput();
            Vivid.Sound.VSoundSys.Init();
            GL.Viewport(0, 0, w, h);
            GL.Scissor(0, 0,w,h);
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.Texture2D);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.Disable(EnableCap.StencilTest);
            GL.Disable(EnableCap.ScissorTest);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthRange(0, 1);

            GL.ClearDepth(1.0f);
            GL.DepthFunc(DepthFunction.Less);
           // UI.UISys.ActiveUI.OnResize(Width, Height);
            VPen.SetProj(0, 0, w, h);
        }

    }
    public class VApp : GameWindow
    {
        public static VApp Link = null;
        private string _Title = "";
        private OpenTK.Graphics.Color4 _BgCol = OpenTK.Graphics.Color4.Black;
        public VStateManager Stater = new VStateManager();
        public VApp()
        {

        }
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
        public void MakeFixed()
        {
            WindowBorder = WindowBorder.Fixed;
        }
        public void MakeWindowless()
        {
            this.WindowBorder = WindowBorder.Hidden;
        }
        public void MakeFullscreen()
        {
            this.WindowState = WindowState.Fullscreen;
        }
        public VApp(string app, int width, int height, bool full) : base(width, height, OpenTK.Graphics.GraphicsMode.Default, app, full ? GameWindowFlags.Fullscreen : GameWindowFlags.Default, DisplayDevice.Default, 4, 5, OpenTK.Graphics.GraphicsContextFlags.ForwardCompatible)

        {
            Link = this;
            _Title = app;
            AppInfo.W = width;
            AppInfo.H = height;
            AppInfo.RW = width;
            AppInfo.RH = height;
            AppInfo.Full = full;
            AppInfo.App = app;
            VImport.RegDefaults();
         for(int i = 0; i < 32; i++)
            {
                VInput.MB[i] = false;
            }
            VPen.InitDraw();
            VInput.InitInput();
            Vivid.Sound.VSoundSys.Init();
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            int bid = 0;
            bid = GetBID(e);
            VInput.MB[bid] = true;
        }

        private static int GetBID(MouseButtonEventArgs e)
        {
            int bid = 0;
            switch (e.Button)
            {
                case MouseButton.Left:
                    bid = 0;
                    break;
                case MouseButton.Right:
                    bid = 1;
                    break;
                case MouseButton.Middle:
                    bid = 2;
                    break;
            }

            return bid;
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            int bid = GetBID(e);
            VInput.MB[bid] = false;
        }
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            VInput.MX = e.X;
            VInput.MY = e.Y;
            VInput.MZ = e.Mouse.Wheel;
            VInput.MDX = e.XDelta;
            VInput.MDY = e.YDelta;
        }
        protected override void OnKeyDown(KeyboardKeyEventArgs e)
        {
            if(e.Key == Key.ShiftLeft || e.Key == Key.ShiftRight)
            {
                VInput.ShiftIn = true;
                return;
            }
            if(VInput.Keys.ContainsKey(e.Key))
            {

            }
            else
            {
                VInput.Keys.Add(e.Key, true);
            }
        }
        protected override void OnKeyUp(KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.ShiftLeft || e.Key == Key.ShiftRight)
            {
                VInput.ShiftIn = false;
                return;
            }
            if (VInput.Keys.ContainsKey(e.Key))
            {
                VInput.Keys.Remove(e.Key);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            AppInfo.W = Width;
            AppInfo.H = Height;
            AppInfo.RW = Width;
            AppInfo.RH = Height;
            GL.Viewport(0, 0, Width, Height);
            GL.Scissor(0, 0, Width, Height);
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.Texture2D);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.Disable(EnableCap.StencilTest);
            GL.Disable(EnableCap.ScissorTest);
          //  GL.Disable(EnableCap.Lighting);

            //GL.DepthFunc(DepthFunction.Greater);

     
            GL.Enable(EnableCap.DepthTest);
            GL.DepthRange(0,1);

            GL.ClearDepth(1.0f);
            GL.DepthFunc(DepthFunction.Less);
            UI.UISys.ActiveUI.OnResize(Width, Height);
          // GL.DepthFunc(DepthFunction.Lequal);
        }


        protected override void OnLoad(EventArgs e)
        {
            CursorVisible = true;
            VPen.SetProj(0, 0, Width, Height);


        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            Sound.VSoundSys.Update();
            Stater.Update();
            VInput.MDX = 0;
            VInput.MDY = 0;
        }
        public int fpsL=0, fps=0, frames=0;

        protected override void OnRenderFrame(FrameEventArgs e)
        {

            if (Environment.TickCount>fpsL+1000)
            {
                fpsL = Environment.TickCount + 1000;
                fps = frames;
                frames = 0;
    
            }
            frames++;
            Title = AppName;
            Title += $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";
        
            GL.ClearColor(_BgCol);

           // GL.DepthMask(true);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            Stater.SmartRender();

            SwapBuffers();
        }


    }
}
