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
        public VTexCube TEnv;
        public float envS = 0.1f;
        public OpenTK.Vector3 Spec = new OpenTK.Vector3(0.6f, 0.4f, 0.2f);
        public float Shine = 30.0f;
        public static VMaterial Active = null;
        public void LoadTexs(string folder,string name)
        {
            TCol = new VTex2D(folder + "//" + name + "_c.png",LoadMethod.Single);
            TNorm = new VTex2D(folder + "//" + name + "_n.png",LoadMethod.Single);
        }
        public virtual void Bind()
        {
            if(TCol!=null) TCol.Bind(0);

            if (TNorm != null) TNorm.Bind(1);

            if (TEnv != null) TEnv.Bind(2);
           
            Active = this;
        }
        public virtual void Release()
        {
            if (TCol != null) TCol.Release(0);
          
            if(TNorm!=null) TNorm.Release(1);
            if(TEnv!=null) TEnv.Release(2);
            Active = null;
        }
    }
}
