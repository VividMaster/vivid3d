using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Vivid.State
{
    public class VStateManager
    {
        public Stack<VAppState> States = new Stack<VAppState>();
        public List<VAppState> ConStates = new List<VAppState>();
        public Thread ConThread = null;
        public Mutex ConTex = new Mutex();
        public VStateManager()
        {
            ConThread = new Thread(new ThreadStart(_ConThread));
            ConThread.Start();

        }
        public void _ConThread()
        {
            while (true)
            {
                ConTex.WaitOne();
                foreach(var cs in ConStates)
                {
                    cs.Update();
                    if(cs.CheckActive()==false)
                    {
                        ConStates.Remove(cs);
                        break;
                    }
                }
                ConTex.ReleaseMutex();
                Thread.Sleep(1000 / 60);
            }
        }
        public void Update()
        {
            if (States.Count == 0) return;
            var s = States.Peek();
            s.Update();
        }
        public void SmartRender()
        {
            if (States.Count > 0)
            {
                var s = States.Peek();
                s.PreRender();
                s.Render();
                s.PostRender();
            }

            foreach (var cs in ConStates)
            {
                cs.PreRender();
                cs.Render();
                cs.PostRender();
            }
        }
    
     
        public void PushState(VAppState s)
        {
        
            States.Push(s);
            s.Init();
        }
        public void AddConState(VAppState s)
        {
            s.Init();
            ConStates.Add(s);
           
        }
        public void PopState()
        {
            var s = States.Pop();
            s.Finish();
        }
    }
}
