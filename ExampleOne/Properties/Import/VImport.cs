using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Scene;
using System.IO;
namespace Vivid.Import
{
    public static class VImport
    {
        public static Dictionary<string, VImporter> Imports = new Dictionary<string, VImporter>();
        public static void RegDefaults()
        {
            RegImp(".3ds", new VAssImpImp());
            RegImp(".fbx", new VAssImpImp());
            RegImp(".blend", new VAssImpImp());
            RegImp(".dae", new VAssImpImp());
        }
        public static void RegImp(string key,VImporter imp)
        {
            Imports.Add(key, imp);
        }
        public static VImporter GetImp(string key)
        {
            if (Imports.ContainsKey(key))
            {
                return Imports[key];
            }
            return null;
        }
        public static VSceneNode ImportNode(string path)
        {
            string key = new FileInfo(path).Extension;
            var imp = Imports[key];
            var r=imp.LoadNode(path);
            return r;
           
        }
    }
}
