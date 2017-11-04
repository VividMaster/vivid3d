using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using Vivid.Input;

namespace Vivid.UI.UIWidgets
{
    public class UITextEntryLine : UIWidget
    {
        public int CarrotPos = 0;
        public UITextEntryLine(int x, int y, int w, string def = "", UIWidget top = null) : base(x, y, w, 30, def, top)
        {
            Name = "";
            NextOn = Environment.TickCount;
        }
        bool CarrotDraw = true;
        public bool CarrotOn = false;
        public int NextOn = 0;
        public override void OnActivate()
        {
            CarrotOn = true;
        }
        public override void OnDeactivate()
        {
            CarrotOn = false;
        }
        public override void Update()
        {
            if(Environment.TickCount>NextOn+500)
            {
                if (CarrotDraw)
                {
                    CarrotDraw = false;
                }
                else
                {
                    CarrotDraw = true;
                }
                NextOn = Environment.TickCount;
            }
        }
        public override void Draw()
        {
           
           
            UISys.Skin().DrawBox((int)WidX, (int)WidY, (int)WidW, (int)WidH);
            string nt = Name;
            if (CarrotOn && CarrotDraw)
            {
                if (Name.Length == 0)
                {
                    nt = "|";
                }
                else
                {
                    if (Name.Length == 1)
                    {
                        if(CarrotPos==0)
                        {
                            nt = "|" + nt;
                        }
                        else
                        {
                            nt = nt + "|";
                        }
                    }
                    else
                    {
                        nt = nt.Substring(0, CarrotPos ) + "|" + nt.Substring(CarrotPos);
                    }
                }
            }
            UISys.Skin().DrawBoxText((int)WidX + 3, (int)WidY + 3, nt);
           
        }
        private void Add(string k)
        {
          
            if(Name.Length ==0)
            {
                Name = k;
                CarrotPos = 1;
                Console.WriteLine("=0");
                return;
            }
            if(CarrotPos == Name.Length)
            {
                Name += k;
                CarrotPos++;
                Console.WriteLine("1=1");
                return;
            }
            if(Name.Length==1 && CarrotPos ==1)
            {
                Name += k;
                CarrotPos++;
                return;
            }
            if(CarrotPos==0)
            {
                Name = k + Name;
                CarrotPos++;
                return;
            }
            Name = Name.Substring(0, CarrotPos) + k + Name.Substring(CarrotPos);
            CarrotPos++;
        }
        private void Del()
        {

           
            if (Name.Length == 1)
            {
                Name = "";
                CarrotPos = 0;
                return;
            }
            if (CarrotPos < Name.Length)
            {
                Name = Name.Substring(0, CarrotPos - 1) + Name.Substring(CarrotPos);
                CarrotPos--;
            }
            else
            {
                Name = Name.Substring(0, Name.Length - 1);
                CarrotPos--;
            }
            if (CarrotPos < 0) CarrotPos = 0;
        }
        public override void KeyLeft()
        {
            if (CarrotPos > 0) CarrotPos--;
        }
        public override void KeyRight()
        {
            if (CarrotPos < Name.Length) CarrotPos++;
        }
        public override void KeyAdd(Key k, bool shift)
        {
            
            if (k == Key.Minus)
            {
                if (shift)
                {
                    Add("_");
                }
                else
                {
                    Add("-");
                }
            }
            if(k == Key.Plus)
            {
                if (shift)
                {
                    Add("+");
                }
                else
                {
                    Add("=");
                }
            }
            if(k == Key.Comma)
            {
                if (shift)
                {
                    Add("<");
                  
                }
                else
                {
                    Add(",");
                }
            }
            if (k == Key.Period)
            {
                if (shift)
                {
                    Add(">");
                }
                else
                {
                    Add(".");
                }
            }
            
            if(k == Key.Space)
            {
                Add(" ");
                return;
            }
            if(k == Key.Tab)
            {
                Add(" ");
                return;
            }
            if (VInput.TextKey(k))
            {
                string cs = k.ToString();
                if (cs.Contains("Number"))
                {
                    Console.WriteLine("Number:" + cs);
                    string ac= cs.Substring(6, 1);
                    Console.WriteLine("AC:" + ac);
                    if (shift)
                    {
                        switch(int.Parse(ac))
                        {
                            case 1:
                                ac = "!";
                                break;
                            case 2:
                                ac = "@";
                                break;
                            case 3:
                                ac = "#";
                                break;
                            case 4:
                                ac = "$";
                                break;
                            case 5:
                                ac = "%";
                                break;
                            case 6:
                                ac = "^";
                                break;
                            case 7:
                                ac = "&";
                                break;
                            case 8:
                                ac = "*";
                                break;
                            case 9:
                                ac = "(";
                                break;
                            case 0:
                                ac = ")";
                                break;
                        }
                        Add(ac);
                        return;
                    }
                    else
                    {
                        Add(ac);
                    }
                    return;
                }
                if (shift)
                {
                    Add(k.ToString().ToUpper());
                }
                else
                {
                    Add(k.ToString().ToLower());
                }
            }
        }
        public override void KeyDel()
        {
            if(CarrotPos ==0)
            {
                if(Name.Length>0)
                {
                    Name = Name.Substring(1);
                    return;
                }
                return;
            }
            if (CarrotPos < Name.Length)
            {
                if (CarrotPos + 1 <= Name.Length)
                {
                    Name = Name.Substring(0, CarrotPos) + Name.Substring(CarrotPos + 1);
                }
            }

        }
        public override void KeyBackSpace()
        {
            if (Name.Length > 1)
            {

                //Name = Name.Substring(0, Name.Length - 1);
                Del();
            }
            else
            {
                Name = "";
            }
                    
                    


        }
    }
}
