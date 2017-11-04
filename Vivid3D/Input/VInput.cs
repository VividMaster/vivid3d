using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Input;
namespace Vivid.Input
{
    public class VInput
    {
        public static void InitInput()
        {
            for(int i=0;i<32;i++)
            {
                MB[i] = false;
            }
        }
        public static int MX=0, MY=0, MZ=0;
        public static int MDX=0, MDY=0, MDZ=0;
        public static bool[] MB = new bool[32];
        public static Dictionary<Key, bool> Keys = new Dictionary<OpenTK.Input.Key, bool>();
        public static bool KeyIn(Key k)
        {
            if (Keys.ContainsKey(k)) return true;
            return false;
        }
        public static List<Key> KeysIn()
        {
            List<Key> ki = new List<Key>();
            foreach(var k in Keys)
            {
                ki.Add(k.Key);
            }
            return ki;
        }
        public static bool IsKeyIn(Key k)
        {
            return Keys.ContainsKey(k);
        }
        public static bool AnyKey()
        {
            return Keys.Count > 0;
        }
    }
}
