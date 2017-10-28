using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivid.UI
{
    public class UIWidget
    {
        public UIWidget Top;
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
        public virtual void OnUpdate()
        {

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
