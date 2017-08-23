using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.App;
using Vivid.State;
using Vivid.Texture;
namespace CubeConvert
{
    class Program
    {
        public class Convert : VAppState
        {
            public string p;
            public override void InitState()
            {
                Console.WriteLine("Writing texture.");
                VTextureUtil.ConvertCubeMap(p);
                Console.WriteLine("wrote.");
                while (true)
                {
                    System.Threading.Thread.Sleep(20);
                }
            }
        }
        static void Main(string[] args)
        {
            VApp e1 = new VApp("Vivid3D - Example One", 800, 600, false);
            var c = new Convert();
            c.p = args[0];
            e1.PushState(c);

            e1.Run();
        }
    }
}
