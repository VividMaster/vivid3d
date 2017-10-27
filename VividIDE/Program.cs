using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid;
using Vivid.App;
using Vivid.State;
using Vivid.Scene;
using Vivid.Visuals;
using Vivid.UI;
using Vivid.UI.UIWidgets;
using Vivid.Import;
namespace VividIDE
{

    public class VIDE : VAppState
    {
     
        public override void InitState()
        {
            VAssImpImp.IPath = "c:/med/";
          

        }

        public override void Render()
        {
      
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VApp e1 = new VApp("Vivid3D - IDE", 1024, 768, false);
            e1.PushState(new VIDE());
            e1.Run();
        }
    }
}
