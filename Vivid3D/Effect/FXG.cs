using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using Vivid.Scene;
using Vivid.Data;
namespace Vivid.Effect
{
    public static class FXG
    {
        public static Matrix4 Local = Matrix4.Identity;
        public static Matrix4 Proj = Matrix4.Identity;
        public static VCam Cam = null;
        public static VSceneEntity Ent = null;
        public static VMesh Mesh = null;
    }
}
