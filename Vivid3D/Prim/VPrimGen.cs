using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Data;
using Vivid.Scene;
namespace Vivid.Prim
{
    public class VPrimGen
    {
        public static void Cube(float s)
        {
            VMesh m = new VMesh(32, 8);

           

            VSceneEntity e = new VSceneEntity();
            e.AddMesh(m);
            e.Meshes[0].Final();

        }
    }
}
