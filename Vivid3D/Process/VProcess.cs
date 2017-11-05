using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Vivid.Processes
{
    public enum ProcessType
    {
        Run,Wait
    }
    public class VProcess
    {
        public Process Pro = null;
        public VProcess(string file,ProcessType type,string args="")
        {
            ProcessStartInfo si = new ProcessStartInfo(file);
            si.WindowStyle = ProcessWindowStyle.Normal;
            si.WorkingDirectory = "c:/vivid3d/";
            si.CreateNoWindow = true;
            si.Arguments = args;

            if (type == ProcessType.Wait)
            {
                using (Pro = Process.Start(si))
                {
                    Pro.WaitForExit();

                }
            }
            else
            {
                Pro = Process.Start(si);
            }

        }
    }
}
