using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Scene;
namespace Vivid.Import
{
    public class VImporter
    {
        public string Ext = "";
        public virtual VSceneNode LoadNode(string path)
        {
            return null;
        }
        public virtual VSceneGraph LoadScene(string path)
        {

            return null;
        }
    }
}
