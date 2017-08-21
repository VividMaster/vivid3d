using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.Effect
{
    public class VEDepth : VEffect
    {
        public VEDepth() : base("","vsDepth.txt","fsDepth.txt")
        {

        }
        public override void SetPars()
        {
         
            //SetMat("MVP", Effect.FXG.Local * FXG.Proj);
            SetMat("model", Effect.FXG.Local);
            SetMat("cam", Effect.FXG.Cam.CamWorld * OpenTK.Matrix4.Invert(OpenTK.Matrix4.CreateTranslation(FXG.Cam.WorldPos)));
            SetMat("proj", FXG.Cam.ProjMat);
            SetVec3("camP", FXG.Cam.WorldPos);
            SetFloat("minZ", FXG.Cam.MinZ);
            SetFloat("maxZ", FXG.Cam.MaxZ);
            
     
        
    }
    }
}
