using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Vivid.App;
namespace Vivid.Scene
{
    public class VCam : VSceneNode
    {
        public Matrix4 ProjMat
        {
            get
            {
                return Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(35), AppInfo.RW / AppInfo.RH, MinZ, MaxZ);
            }
        }
        public bool DepthTest = true;
        public bool AlphaTest = false;
        public bool CullFace = true;
        public float MinZ = 1f, MaxZ = 700;
        public VCam()
        {
           
        }
        public Matrix4 CamWorld
        {
            get
            {
       
                return Matrix4.Invert(World);
            }
        }
    }
}
