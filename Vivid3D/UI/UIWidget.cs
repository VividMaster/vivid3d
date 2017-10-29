using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivid.Input;
namespace Vivid.UI
{
    public class UIWidget
    {
        public UISys Owner = null;
        public UIWidget Top;
        public float AR = 1.0f;
        public UISys GetOwn
        {
            get
            {
                if (Owner != null) return Owner;
                if (Top != null)
                {
                    return Top.GetOwn;
                }
                return null;
            }
        }
        public List<UIWidget> Sub = new List<UIWidget>();
        public float WidX
        {
            get
            {
                if (Top == null) return _WidX;
                return Top.WidX + _WidX;
            }
            set
            {
                _WidX = value;
            }
        }
        public float WidY
        {
            get
            {
                if (Top == null) return _WidY;
                return Top.WidY + _WidY;
            }
            set
            {
                _WidY = value;
            }
        }
        public float WidW = 0, WidH = 0;
        private float _WidX = 0, _WidY = 0;
        public string Name = "";
        public List<String> Text = new List<string>();
        public Dictionary<string, UIWidget> WidMap = new Dictionary<string, UIWidget>();
        public void AddWidget(UIWidget w)
        {
            Sub.Add(w);
        }
        public UIWidget(float x, float y, float w = 0, float h = 0, string text = "", UIWidget top = null)
        {
            Top = top;
            WidX = x;
            WidY = y;
            WidW = w;
            WidH = h;
            Name = text;
        }
        public virtual void OnEnter()
        {

        }
        public virtual void OnLeave()
        {

        }
        public virtual void OnHover()
        {

        }
        public virtual void OnMouseDown(UIMouseButton b)
        {

        }
        public virtual void OnMouseUp(UIMouseButton b)
        {

        }
        public virtual void OnActivate()
        {

        }
        public virtual void OnDeactivate()
        {

        }
        public virtual void OnActive()
        {

        }
        public virtual bool InBounds()
        {
            return false;
        }
        public virtual void OnUpdate()
        {
            foreach (var w in Sub)
            {
                w.OnUpdate();
            }
            if (InBounds())
            {
                if (UISys.Over == this)
                {
                    this.OnHover();
                }
                if (UISys.Over == null)
                {
                    UISys.Over = this;
                    this.OnEnter();
                }
                if (UISys.Over != null && UISys.Over != this)
                {
                    UISys.Over.OnLeave();
                    UISys.Over = this;
                    UISys.Over.OnEnter();
                }

            }
            else
            {
                if (UISys.Over == this)
                {
                    UISys.Over.OnLeave();
                    UISys.Over = null;
                }
            }
            if (VInput.MB[0])
            {
                if (UISys.Over != null)
                {
                    if (UISys.Over == this)
                    {
                        if (UISys.Active != this)
                        {
                            if (UISys.Active != null)
                            {
                                UISys.Active.OnDeactivate();
                            }
                            UISys.Active = this;
                            this.OnActivate();
                        }
                    }
                }
                else
                {

                }
            }
            if (InBounds())
            {
                if (VInput.MB[0])
                {
                   
                    if (UISys.Pressed == null)
                    {
                        Console.WriteLine("Pushed:" + Name);
                        OnMouseDown(UIMouseButton.Left);
                        UISys.Pressed = this;
                    }

                }
                else
                {
                    if (UISys.Pressed == this)
                    {
                        Console.WriteLine("Released.");
                        OnMouseUp(UIMouseButton.Left);
                        UISys.Pressed = null;
                    }
                }
            }
            else
            {
                if (UISys.Pressed != null)
                {
                   // UISys.Pressed.OnMouseUp(UIMouseButton.Left);
                    //UISys.Pressed = null;
                }
            }



        }
        public virtual void OnDraw()
        {
            this.Draw();
            foreach(var w in Sub)
            {
                w.OnDraw();
            }
        }
        public virtual void Draw()
        {

        }

    }
}
