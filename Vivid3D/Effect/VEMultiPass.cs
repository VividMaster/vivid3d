using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.Effect
{
    public class VEMultiPass : VEffect
    {
        public VEMultiPass() : base("", "vsMP1.txt", "fsMP1.txt")
        {

        }
        public override void SetPars()
        {
            if (Material.VMaterial.Active.TCol != null)
            {
                SetBool("eC", true);
            }
            else
            {
                SetBool("eC", false);
            }
            if(Material.VMaterial.Active.TNorm != null)
            {
                SetBool("eN", true);
            }
            else
            {
                SetBool("eN", false);
            }
            if (Material.VMaterial.Active.TEnv != null)
            {
                SetBool("eE", true);
            }
            else
            {
                SetBool("eE", false);
               // Environment.Exit(0);
            }
            //SetMat("MVP", Effect.FXG.Local * FXG.Proj);
            SetMat("model", Effect.FXG.Local);
            SetMat("cam",OpenTK.Matrix4.Invert(OpenTK.Matrix4.CreateTranslation(FXG.Cam.WorldPos)) * FXG.Cam.CamWorld );
            SetMat("proj", FXG.Cam.ProjMat);
            SetVec3("camP", FXG.Cam.WorldPos);
            SetVec3("lP", Lighting.VLight.Active.WorldPos);
            SetVec3("lC", Lighting.VLight.Active.Diff);
            SetFloat("atten", Lighting.VLight.Active.Atten);
            SetFloat("ambCE", Lighting.VLight.Active.AmbCE);
            SetFloat("matS", Material.VMaterial.Active.Shine);
            SetVec3("matSpec", Material.VMaterial.Active.Spec);
            SetFloat("envS", Material.VMaterial.Active.envS);
            SetTex("tC", 0);
            SetTex("tN", 1);
            SetTex("tE", 2);
        }
    }
}
