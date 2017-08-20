using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Scene;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
namespace Vivid.Lighting
{
    public enum LightType
    {
        Ambient,Directional,Point
    }
    public class VLight : VSceneNode
    {
        public static VLight Active = null;
        public bool CastShadows = true;
        public LightType Type = LightType.Point;
        public Vector3 Diff = new Vector3(0.5f, 0.5f, 0.5f);
        public Vector3 Spec = new Vector3(0, 0, 0);
        public Vector3 Amb = new Vector3(0, 0, 0);
        public float Atten = 0.002f;
        public float AmbCE = 0.005f;

        
    }
}
