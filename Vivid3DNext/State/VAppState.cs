using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.State
{
    public class VAppState
    {
        public string Name = "";
        public bool Active = false;
        public bool AlreadyInit = false;
        public void Start()
        {
            Init();
        }
        public void Init()
        {
            if (!AlreadyInit)
            {
                InitState();
                AlreadyInit = true;
            }
        }
        public virtual void InitState()
        {

        }
        public void Finish()
        {
            Active = false;
            FinishState();
        }
        public virtual void FinishState()
        {

        }
        public virtual void Update()
        {

        }
        public virtual bool CheckActive()
        {
            return Active;
        }
        public virtual void PreRender()
        {

        }
        public virtual void Render()
        {

        }
        public virtual void PostRender()
        {

        }
    }

}
