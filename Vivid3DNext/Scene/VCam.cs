using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Vivid.System;
namespace Vivid.Scene
{
    public class VCam : VSceneNode
    {
        public Matrix4 ProjMat = Matrix4.Identity;
        public bool DepthTest = true;
        public bool AlphaTest = false;
        public bool CullFace = true;
        public VCam()
        {
            ProjMat = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(35), AppInfo.W / AppInfo.H, 0.01f, 1000.0f);
        }
        public Matrix4 CamWorld
        {
            get
            {
                Console.WriteLine("CM");
                return Matrix4.Invert(World);
            }
        }
    }
}
