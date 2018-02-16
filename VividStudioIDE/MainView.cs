using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WeifenLuo.WinFormsUI;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform;
using OpenTK;
using Vivid.App;
using Vivid.Draw;
using Vivid.Font;
namespace VividStudioIDE
{
    public partial class MainView : DockContent
    {
                public MainView()
        {
            InitializeComponent();
            Text = "3D View";
        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }
        private VForm VF = null;
        private void MainView_Load(object sender, EventArgs e)
        {
            //if(GLO == null)
            //{
              
            
            GLO.Resize += GLO_Resize;
            GLO.Paint += GLO_Paint;
            Text =
              GL.GetString(StringName.Vendor) + " " +
              GL.GetString(StringName.Renderer) + " " +
              GL.GetString(StringName.Version);
            VF = new VForm();
            VF.Set(Width, Height);
            Application.Idle += Application_Idle;
            //MessageBox.Show(Text);

            GLO.Invalidate();

        }

        private void Application_Idle(object sender, EventArgs e)
        {
          while(GLO.IsIdle)
            {
                Render();
            }
        }
        public void Render()
        {
            GLO.MakeCurrent();
            GL.ClearColor(Color.Gray);
            // GL.DepthMask(true);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            GLO.SwapBuffers();
            GLO.Invalidate();

        }
        private void GLO_Paint(object sender, PaintEventArgs e)
        {


            Render();

        }

        private void GLO_Resize(object sender, EventArgs e)
        {
            VF.SetSize(Width, Height);

        }

        private void GLO_Paint_1(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}
