using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Texture;
namespace Vivid.Material
{
    public class VMaterial
    {
        public VTex2D TCol;
        public VTex2D TNorm;
        public VTex2D TSpec;
        public VTex2D TAO;
        public void LoadTexs(string folder,string name)
        {
            TCol = new VTex2D(folder + "//" + name + "_c.png",LoadMethod.Single);
            TNorm = new VTex2D(folder + "//" + name + "_n.png",LoadMethod.Single);
        }
        public virtual void Bind()
        {
            TCol.Bind(0);
        }
        public virtual void Release()
        {
            TCol.Release(0);
        }
    }
}
